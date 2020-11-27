using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class PrestamoNegocios
    {
        private List<Prestamo> _lstPrestamo;
        public PrestamoNegocios()
        {
            _lstPrestamo = new List<Prestamo>();
            RecargarLista();
        }
        private void RecargarLista()
        {
            _lstPrestamo = PrestamosMapper.TraerPrestamos();
        }
        public List<Prestamo> TraerPrestamos()
        {
            return _lstPrestamo;
        }
        private string Reglas(Prestamo prestamo)
        {
            string mensaje = "";
            if (!ClienteMapper.TraerClientes().Any(x => x.Id == prestamo.IdCliente))
                mensaje += "El Cliente no esta registrado \n";

            return mensaje;
        }
        public int IngresarPrestamo(Prestamo prestamo)
        {
            string regla = Reglas(prestamo);
            if (!string.IsNullOrEmpty(regla))
            {
                throw new Exception(regla);
            }
            else
            {
                TransactionResult resultado = PrestamosMapper.Insert(prestamo);
                if (resultado.IsOk)
                {
                    RecargarLista();
                    return resultado.Id;
                }
                else
                {
                    throw new Exception(resultado.Error);
                }

            }
        }
    }
}
