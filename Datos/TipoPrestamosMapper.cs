using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Configuration;

namespace Datos
{
    public class TipoPrestamosMapper
    {
        public static List<TipoPrestamos> TraerTipoPrestamos()
        {
            return GenericMapper<TipoPrestamos>.TraerTodo("/prestamotipo/");
        }
    }
}
