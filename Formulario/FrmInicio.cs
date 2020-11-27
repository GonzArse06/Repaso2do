using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FrmInicio : Form
    {
        private Form _formulario;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void aBMClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formulario = new FrmCliente();
            _formulario.Show();
        }

        private void aBMPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formulario = new FrmPrestamo();
            _formulario.Show();
        }
    }
}
