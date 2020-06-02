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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            // Cerrar bien una aplicacion windows Form C#
        }

        private void bntIngresar_Click(object sender, EventArgs e)
        {
            ingresarLogin();
        } 

        private void ingresarLogin()
        {
            string user = txtUsuario.Text.TrimEnd().TrimStart();
            string password = txtClave.Text.TrimEnd().TrimStart();

            if (!string.IsNullOrEmpty(user))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    TBL_USUARIO _infoUsuario = new TBL_USUARIO();
                    _infoUsuario = LogicaUsuarios.getUsersxLogin(user, password);
                    if (_infoUsuario != null)
                    {
                        MessageBox.Show("Bienvenido al sistema "+ _infoUsuario.usu_correo + "\nRol Usuario "+ _infoUsuario.TBL_ROL.rol_descripcion, "Sistema Help Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrecta ", "Sistema Help Desk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtClave.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Clave Campo Requerido");
                }
            }
            else
            {
                MessageBox.Show("Usuario Campo Requerido");
            }


        }
    }
}
