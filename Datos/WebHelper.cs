using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace Datos
{
    public class WebHelper
    {
        static WebClient _client;
        static string _rutaBase;

        static WebHelper()
        {
            _client = new WebClient();
            _client.Encoding = Encoding.UTF8;
            _rutaBase = ConfigurationManager.AppSettings["urlAPI"];
            _client.Headers.Add("ContentType", "Application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        ///<summary></summary>
        ///<param name="url">/cliente/</param>
        ///<returns></returns>
        public static string Get(string url)
        {
            string uri = _rutaBase + url;
            return _client.DownloadString(uri);
        }
        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = _rutaBase + url;
            try
            {
                var respuesta = _client.UploadValues(uri, parametros);
                return Encoding.Default.GetString(respuesta);
            }
            catch (Exception ex)
            {
                return "{\"isOk\":false,\"id\":-1,\"error\":'" + ex.Message + "' }";
            }
        }
    }
}
