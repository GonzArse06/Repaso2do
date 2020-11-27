using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        int _dni, _id;
        string _nombre, _apellido, _direccion, _email, _telefono, _usuario, _host;
        DateTime _fechaNacimiento, _fechaAlta;
        bool _activo;

        public Cliente(int dni, string nombre, string apellido, string direccion, int telefono, string email, DateTime fechaNacimiento)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono.ToString();
            _email = email;
            _fechaNacimiento = fechaNacimiento;
            _fechaAlta = DateTime.Now;
            _activo = true;
        }

        public int Dni { get => _dni; set => _dni = value; }
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Host { get => _host; set => _host = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public int Edad { get => (int)((DateTime.Now - _fechaNacimiento).TotalDays / 356); }

        public override string ToString()
        {
            return string.Format("Id: {0} - Cliente: {1}, {2}", this._id, this._apellido, this._nombre);
        }
    }
}
