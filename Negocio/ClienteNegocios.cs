using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ClienteNegocios
    {
        private List<Cliente> _lstClientes;
        public ClienteNegocios()
        {
            _lstClientes = new List<Cliente>();
            RecargarLista();
        }
        private void RecargarLista()
        {
            _lstClientes = ClienteMapper.TraerClientes();
        }
        public List<Cliente> TraerClientes()
        {
            return _lstClientes;
        }
        private string Reglas(Cliente cliente)
        {
            string mensaje = "";
            if (_lstClientes.Any(x => x.Dni == cliente.Dni))
                mensaje += "El DNI ya esta registrado \n";

            return mensaje;
        }
        public int IngresarCliente(Cliente cliente)
        {
            string regla = Reglas(cliente);
            if (!string.IsNullOrEmpty(regla))
            {
                throw new Exception(regla);
            }
            else
            {
                TransactionResult resultado = ClienteMapper.Insert(cliente);
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
