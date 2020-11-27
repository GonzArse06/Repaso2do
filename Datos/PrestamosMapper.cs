using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class PrestamosMapper
    {
        public static List<Prestamo> TraerPrestamos()
        {
            return GenericMapper<Prestamo>.TraerTodo("/prestamo/" + ConfigurationManager.AppSettings["Legajo"]);
        }
        public static TransactionResult Insert(Prestamo prestamo)
        {
            return GenericMapper<Prestamo>.Insert(prestamo, "/prestamo/");
        }
    }
}
