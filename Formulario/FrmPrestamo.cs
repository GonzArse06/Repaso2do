using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Formulario
{
    public partial class FrmPrestamo : Form
    {
        private PrestamoNegocios _prestamoNegocios;
        private TipoPrestamosNegocio _tipoPrestamosNegocio;
        public FrmPrestamo()
        {
            InitializeComponent();
            _prestamoNegocios = new PrestamoNegocios();
            _tipoPrestamosNegocio = new TipoPrestamosNegocio();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            RecargarListBox();
        }
        private void RecargarListBox()
        {
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = _prestamoNegocios.TraerPrestamos();
            lstTipoPrestamo.DataSource = null;
            lstTipoPrestamo.DataSource = _tipoPrestamosNegocio.TraerTipoPrestamos();
        }

        private void lstTipoPrestamo_DoubleClick(object sender, EventArgs e)
        {
            TipoPrestamos tipo = (TipoPrestamos)lstTipoPrestamo.SelectedItem;
            if (tipo != null && tipo is TipoPrestamos)
            {
                txtLinea.Text = tipo.Linea;
                txtTNA.Text = tipo.TNA.ToString();
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            GeneralPrestamo(sender);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            GeneralPrestamo(sender);
        }
        private void GeneralPrestamo(object sender)
        {
            //validaciones de fomulario
            try
            {
                Prestamo prestamo = new Prestamo(txtLinea.Text, double.Parse(txtTNA.Text), int.Parse(txtPlazo.Text), double.Parse(txtMonto.Text), int.Parse(txtIdCliente.Text));
                txtCuotaCapital.Text = string.Format("{0:c}", prestamo.CuotaCapital);
                txtCuotaInteres.Text = string.Format("{0:c}", prestamo.CuotaInteres);
                txtCuotaTotal.Text = string.Format("{0:c}", prestamo.Cuota);
                if (((ButtonBase)sender).Text == "ALTA")
                { 
                    if (MessageBox.Show("Desea confirmar el prestamo?", "Ingresando prestamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    { 
                        int resultado = _prestamoNegocios.IngresarPrestamo(prestamo);
                        MessageBox.Show("Ingreso exitoso. ID" + resultado);
                        RecargarListBox();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
