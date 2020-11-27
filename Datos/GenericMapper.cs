using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Entidades;
using System.Collections.Specialized;
using System.Configuration;

namespace Datos
{
    public class GenericMapper<T>
    {
        public static List<T> TraerTodo(string url)
        {
            string json =  WebHelper.Get(url);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
        public static TransactionResult Insert(T t,string url)
        {
            NameValueCollection obj = ReverseMap(t);
            string json = WebHelper.Post(url, obj);
            return JsonConvert.DeserializeObject<TransactionResult>(json);
        }
        public static NameValueCollection ReverseMap(T t)
        {
            NameValueCollection a = new NameValueCollection();
            if (t is Cliente cliente)
            {
                a.Add("Id", cliente.Id.ToString());
                a.Add("Dni", cliente.Dni.ToString());
                a.Add("Nombre", cliente.Nombre);
                a.Add("Apellido", cliente.Apellido);
                a.Add("Direccion", cliente.Direccion);
                a.Add("Email", cliente.Email);
                a.Add("Telefono", cliente.Telefono);
                a.Add("FechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));
                a.Add("FechaAlta", cliente.FechaAlta.ToString("yyyy-MM-dd"));
                a.Add("Activo", cliente.Activo.ToString());
                //a.Add("host", cliente.Host.ToString());
                a.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            }
            if (t is Prestamo prestamos)
            {
                a.Add("TNA", prestamos.TNA.ToString());
                a.Add("Linea", prestamos.Linea);
                a.Add("Plazo", prestamos.Plazo.ToString());
                a.Add("IdCliente", prestamos.IdCliente.ToString());
                a.Add("Monto", prestamos.Monto.ToString("#.##")); //habia un error con los decimales.
                a.Add("Cuota", prestamos.Cuota.ToString("#.##"));
                a.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            }
            return a;
        }
    }
}
