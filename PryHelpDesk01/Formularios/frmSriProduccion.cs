using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryHelpDesk01.Formularios
{
    public partial class frmSriProduccion : Form
    {
        public frmSriProduccion()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var p= 5L == 5.0F;
            var q= 24L / 5 == 24 / 5d;

            logicaSri.logicaServiceSri.consultaFacturaSriProduccion(textBox1.Text);
        }
    }
}
