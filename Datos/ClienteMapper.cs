using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Configuration;

namespace Datos
{
    public class ClienteMapper
    {
        public static List<Cliente> TraerClientes()
        {
            return GenericMapper<Cliente>.TraerTodo("/cliente/"+ConfigurationManager.AppSettings["Legajo"]);
        }
        public static TransactionResult Insert(Cliente cliente)
        {
            return GenericMapper<Cliente>.Insert(cliente, "/cliente/");
        }
    }
}
