using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TransactionResult
    {
        bool _isOk;
        int _id;
        string _error;
        public bool IsOk { get => _isOk; set => _isOk = value; }
        public int Id { get => _id; set => _id = value; }
        public string Error { get => _error; set => _error = value; }
    }
}
