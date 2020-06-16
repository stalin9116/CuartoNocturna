using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using LogicaNegocios;

namespace PryHelpDesk01.Formularios
{
    public partial class fmrUsuario : Form
    {
        public fmrUsuario()
        {
            InitializeComponent();
        }

        private void fmrUsuario_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
            cargarRoles();
        }

        private void cargarUsuarios()
        {
            List<TBL_USUARIO> _listaUsuarios = new List<TBL_USUARIO>();
            _listaUsuarios = LogicaUsuarios.getAllUsers();
            if (_listaUsuarios != null && _listaUsuarios.Count > 0)
            {
                gdvUsuarios.DataSource = _listaUsuarios.Select(data => new
                {
                    CODIGO = data.usu_id,
                    USUARIO = data.usu_correo,
                    //CONTRASEÑA = data.usu_password,
                    APELLIDOS = data.usu_apellidos,
                    NOMBRES = data.usu_nombres,
                    ESTADO = data.usu_status,
                    ROL = data.TBL_ROL.rol_descripcion
                }).ToList();
            }
        }

        private void cargarRoles()
        {
            List<TBL_ROL> _listaRol = new List<TBL_ROL>();
            _listaRol = LogicaRol.getAllRoles();
            if (_listaRol != null && _listaRol.Count > 0)
            {
                _listaRol.Insert(0, new TBL_ROL
                {
                    rol_id = 0,
                    rol_descripcion = "Seleccione Rol"
                });
                cmbRol.DataSource = _listaRol;
                cmbRol.DisplayMember = "rol_descripcion";
                cmbRol.ValueMember = "rol_id";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevoUsuario();
        }

        private void nuevoUsuario()
        {
            lblCodigo.Text = "";
            txtCorreo.Clear();
            txtClave.Clear();
            txtApellidos.Clear();
            txtNombres.Clear();
            cmbRol.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validacion de campos nulls

            saveUsuario();
        }

        private void saveUsuario()
        {
            try
            {
                TBL_USUARIO _infoUsuario = new TBL_USUARIO();
                _infoUsuario.usu_correo = txtCorreo.Text.TrimEnd().TrimStart();
                _infoUsuario.usu_apellidos = txtApellidos.Text.TrimEnd().TrimStart().ToUpper();
                _infoUsuario.usu_nombres = txtNombres.Text.TrimEnd().TrimStart().ToUpper();
                //Login MD5 sha1 Encriptacion
                _infoUsuario.usu_password = txtClave.Text;
                _infoUsuario.rol_id = Convert.ToByte(cmbRol.SelectedValue);
                bool result = LogicaUsuarios.saveUser(_infoUsuario);
                if (result)
                {
                    MessageBox.Show("Usuario guardado correctamente", "Sistema HelpDesk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarUsuarios();
                    nuevoUsuario();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar usuario", "Sistema HelpDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteUsuario()
        {
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                var res = MessageBox.Show("Desea eliminar el registro ? ", "Sistema HelpDesk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res.ToString() == "Yes")
                {
                    TBL_USUARIO _infoUser = new TBL_USUARIO();
                    _infoUser = LogicaUsuarios.getUsersXId(Convert.ToInt32(lblCodigo.Text));
                    if (_infoUser != null)
                    {
                        if (LogicaUsuarios.deleteUser(_infoUser))
                        {
                            MessageBox.Show("Registro eliminado correctamente ");
                            cargarUsuarios();
                            nuevoUsuario();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún registro para eliminar ");
            }

        }

        private void txtCorreo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCorreo.Text))
            {
                bool resultadoCorreo = LogicaUsuarios.validarCorreo(txtCorreo.Text);
                if (resultadoCorreo == false)
                {
                    //messagebox
                    txtCorreo.Focus();
                }
            }
        }

        private void gdvUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var codigoUsuario = gdvUsuarios.Rows[e.RowIndex].Cells["CODIGO"].Value;
            var correoUsuario = gdvUsuarios.Rows[e.RowIndex].Cells["USUARIO"].Value;
            var apellidosUsuario = gdvUsuarios.Rows[e.RowIndex].Cells["APELLIDOS"].Value;
            var nombresUsuario = gdvUsuarios.Rows[e.RowIndex].Cells["NOMBRES"].Value;
            var estadoUsuario = gdvUsuarios.Rows[e.RowIndex].Cells["ESTADO"].Value;
            var rolUsuario = gdvUsuarios.Rows[e.RowIndex].Cells["ROL"].Value;
            if (!string.IsNullOrEmpty(codigoUsuario.ToString()))
            {
                lblCodigo.Text = codigoUsuario.ToString();
                txtCorreo.Text = correoUsuario.ToString();
                txtApellidos.Text = apellidosUsuario.ToString();
                txtNombres.Text = nombresUsuario.ToString();
                cmbRol.SelectedIndex = cmbRol.FindString(rolUsuario.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            deleteUsuario();
        }
    }
}
