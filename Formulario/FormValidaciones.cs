using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Formulario
{
    public class FormValidaciones
    {
        public static string CamposVacios(ControlCollection control)
        {
            string mensaje = "";
            foreach (Control a in control)
            {
                if (a is TextBox && a.Enabled == true)
                {
                    if (string.IsNullOrEmpty(a.Text))
                        mensaje += a.Name + "\n";
                }
            }
            if (!string.IsNullOrEmpty(mensaje))
                mensaje = "Existen campos vacios. Revisar los siguientes: \n" + mensaje;

            return mensaje;
        }
        public static bool MailValido(string mail)
        {
            try
            {
                var add = new System.Net.Mail.MailAddress(mail);
                return add.Address == mail;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
    }
    public static class FrmEstaticas
    {        public static void LimpiarTextos(ControlCollection control)
        {
            foreach (Control a in control)
            {
                if (a is TextBox)
                {
                    a.Text = string.Empty;
                }
            }
        }
    }
}
