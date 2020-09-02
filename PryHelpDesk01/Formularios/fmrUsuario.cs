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
            List<TBL_USUARIO> _listaUsuarios = new List<TBL_USUARIO>();
            _listaUsuarios = LogicaUsuarios.getAllUsers();
            if (_listaUsuarios != null && _listaUsuarios.Count > 0)
            {
                cargarUsuarios(_listaUsuarios);
            }
            cargarRoles();
        }

        private void cargarUsuarios(List<TBL_USUARIO> _listaUsuarios)
        {

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
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                updateUsuario();
            }
            else
            {
                saveUsuario();
            }
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
                _infoUsuario.usu_password = LogicaNegocios.complementos.encriptar.GetMD5(txtClave.Text);
                _infoUsuario.rol_id = Convert.ToByte(cmbRol.SelectedValue);
                bool result = LogicaUsuarios.saveUser(_infoUsuario);
                if (result)
                {
                    MessageBox.Show("Usuario guardado correctamente", "Sistema HelpDesk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<TBL_USUARIO> _listaUsuarios = new List<TBL_USUARIO>();
                    _listaUsuarios = LogicaUsuarios.getAllUsers();
                    cargarUsuarios(_listaUsuarios);
                    nuevoUsuario();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar usuario", "Sistema HelpDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateUsuario()
        {
            try
            {
                TBL_USUARIO _infoUsuario = new TBL_USUARIO();
                //_infoUsuario = LogicaUsuarios.getUsersXId(int.Parse(lblCodigo.Text));
                if (_infoUsuario != null)
                {
                    _infoUsuario.usu_id = Convert.ToInt32(lblCodigo.Text);
                    _infoUsuario.usu_correo = txtCorreo.Text.TrimEnd().TrimStart();
                    _infoUsuario.usu_apellidos = txtApellidos.Text.TrimEnd().TrimStart().ToUpper();
                    _infoUsuario.usu_nombres = txtNombres.Text.TrimEnd().TrimStart().ToUpper();
                    //Login MD5 sha1 Encriptacion
                    if (!string.IsNullOrEmpty(_infoUsuario.usu_password = txtClave.Text))
                    {
                        _infoUsuario.usu_password = LogicaNegocios.complementos.encriptar.GetMD5(txtClave.Text);
                    }
                    _infoUsuario.rol_id = Convert.ToByte(cmbRol.SelectedValue);
                    bool result = LogicaUsuarios.updateUser3(_infoUsuario);
                    if (result)
                    {
                        MessageBox.Show("Usuario Modificado correctamente", "Sistema HelpDesk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<TBL_USUARIO> _listaUsuarios = new List<TBL_USUARIO>();
                        _listaUsuarios = LogicaUsuarios.getAllUsers();
                        cargarUsuarios(_listaUsuarios);
                        nuevoUsuario();
                    }
                }
            }
            catch (Exception ex)
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
                            MessageBox.Show("Registro eliminado correctamente jaja ");
                            List<TBL_USUARIO> _listaUsuarios = new List<TBL_USUARIO>();
                            _listaUsuarios = LogicaUsuarios.getAllUsers();
                            cargarUsuarios(_listaUsuarios);
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar(cmbBuscar.Text);
        }

        private void buscar(string op)
        {
            if (!string.IsNullOrEmpty(op))
            {
                List<TBL_USUARIO> _listaUsuarios = new List<TBL_USUARIO>();
                string datoBuscar = txtBuscar.Text;
                switch (op)
                {
                    case "Todos":
                        _listaUsuarios = LogicaUsuarios.getAllUsers();
                        cargarUsuarios(_listaUsuarios);
                        txtBuscar.Clear();
                        break;
                    case "Nombres":
                        _listaUsuarios = LogicaUsuarios.getUsersXNombres(datoBuscar);
                        cargarUsuarios(_listaUsuarios);
                        break;
                    case "Correo":
                        _listaUsuarios = LogicaUsuarios.getUsersXCorreo(datoBuscar);
                        cargarUsuarios(_listaUsuarios);
                        break;
                    case "Apellidos":
                        _listaUsuarios = LogicaUsuarios.getUsersXApellidos(datoBuscar);
                        cargarUsuarios(_listaUsuarios);
                        break;
                    case "Rol":
                        _listaUsuarios = LogicaUsuarios.getUsersXRol(datoBuscar);
                        cargarUsuarios(_listaUsuarios);
                        break;
                } 
            }

        }

    }
}
