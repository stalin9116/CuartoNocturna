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
        }

        private void cargarUsuarios()
        {
            List<TBL_USUARIO> _listaUsuarios = new List<TBL_USUARIO>();
            _listaUsuarios = LogicaUsuarios.getAllUsers();
            if (_listaUsuarios != null && _listaUsuarios.Count > 0)
            {
                gdvUsuarios.DataSource = _listaUsuarios.Select(data=>new { 
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevoUsuario();
        }

        private void nuevoUsuario()
        {
            txtCorreo.Clear();
            txtClave.Clear();
            txtApellidos.Clear();
            txtNombres.Clear();
        }

    }
}
