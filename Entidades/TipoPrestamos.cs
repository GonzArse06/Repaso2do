using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoPrestamos
    {
        private string _linea;
        private double _tna;
        private int _id;

        public string Linea { get => _linea; set => _linea = value; }
        public double TNA { get => _tna; set => _tna = value; }
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return string.Format("{0} - TNA: {1}", this._linea, this._tna);
        }
    }
}
