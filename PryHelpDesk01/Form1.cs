using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryHelpDesk01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.fmrUsuario FrmUsuario = new Formularios.fmrUsuario();
            FrmUsuario.Show();
        }
    }
}
