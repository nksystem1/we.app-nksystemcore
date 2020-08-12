using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using we.app_nksystemcore.Models;
using we.app_nksystemcore.Utilities;

namespace we.app_nksystemcore.ConectionService.Implementation
{
    public class RutaService : IRutaService
    {
        private readonly string BaseUrl = "";
        private readonly HttpClient _ClientHttp;
        private readonly IOptions<ConfigurationManager> _ConfiguratonService;

        public RutaService(IOptions<ConfigurationManager> ConfiguratonService)
        {
            _ConfiguratonService = ConfiguratonService;
            BaseUrl = _ConfiguratonService.Value.UriBaseApi;
            _ClientHttp = new HttpClient();
            _ClientHttp.BaseAddress = new Uri(BaseUrl);
            _ClientHttp.DefaultRequestHeaders.Clear();
            _ClientHttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }        

        public async Task<List<Ruta>> ListarRutas()
        {            
            HttpResponseMessage httpresponse = await _ClientHttp.GetAsync("ruta");
            if (httpresponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var rutaresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Ruta = JsonConvert.DeserializeObject<List<Ruta>>(rutaresponse);
                return Ruta;
            }
            else return null;
        }
        public async Task<Ruta> GuardarRuta(Ruta ruta)
        {           
            string inputJson = Newtonsoft.Json.JsonConvert.SerializeObject(ruta);
            HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
            HttpResponseMessage httpresponse = await _ClientHttp.PostAsync("ruta", inputContent);
            if (httpresponse.IsSuccessStatusCode)
            {
                var rutaresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Ruta = JsonConvert.DeserializeObject<Ruta>(rutaresponse);

                return Ruta;
            }
            else
                return null;
        }

        public async Task<Ruta> ModificarRuta(Ruta ruta)
        {
            string inputJson = Newtonsoft.Json.JsonConvert.SerializeObject(ruta);
            HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
            HttpResponseMessage httpresponse = await _ClientHttp.PutAsync("ruta", inputContent);
            if (httpresponse.IsSuccessStatusCode)
            {
                var rutaresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Ruta = JsonConvert.DeserializeObject<Ruta>(rutaresponse);
                return Ruta;
            }
            else
                return null;
        }

        public async Task<Ruta> BuescarRutaPorCodigo(string Codigo)
        {         
            HttpResponseMessage httpresponse = await _ClientHttp.GetAsync("ruta/"+Codigo);
            if (httpresponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var rutaresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Ruta = JsonConvert.DeserializeObject<Ruta>(rutaresponse);
                return Ruta;
            }
            else return null;
        }       
    }
}
