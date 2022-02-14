using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Helpers
{
    public  class ClienteHttp
    {
        public string ObtenerRespuesta(string Baseurl) 
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                var Res = client.GetAsync("/").ConfigureAwait(false).GetAwaiter().GetResult();

                var result = Res.Content.ReadAsStringAsync().Result;

                return result;
            }
        }

    }
}
