using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class TipoPrestamosNegocio
    {
        private List<TipoPrestamos> _lstTipoPrestamos;
        public TipoPrestamosNegocio()
        {
            _lstTipoPrestamos = new List<TipoPrestamos>();
        }
        public List<TipoPrestamos> TraerTipoPrestamos()
        {
            _lstTipoPrestamos = TipoPrestamosMapper.TraerTipoPrestamos();
            return _lstTipoPrestamos;
        }

    }
}
