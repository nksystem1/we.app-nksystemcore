using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using we.app_model.Data;
using we.app_nksystemcore.Utilities;

namespace we.app_nksystemcore.ConectionService.Implementation
{
    public class VendedorService : IVendedorService
    {
        private readonly string BaseUrl = "";
        private readonly HttpClient _Clienthttp;
        private readonly IOptions<ConfigurationManager> _ConfiguratonService;
        HttpResponseMessage httpresponse;

        public VendedorService(IOptions<ConfigurationManager> ConfiguratonService)
        {
            _ConfiguratonService = ConfiguratonService;
            BaseUrl = _ConfiguratonService.Value.UriBaseApi;
            _Clienthttp = new HttpClient();
            _Clienthttp.BaseAddress = new Uri(BaseUrl);
            _Clienthttp.DefaultRequestHeaders.Clear();
            _Clienthttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Vendedor> GuardarVendedor(Vendedor vendedor)
        {
          
            string inputJson = Newtonsoft.Json.JsonConvert.SerializeObject(vendedor);
            HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
            httpresponse = await _Clienthttp.PostAsync("vendedor", inputContent);
            if (httpresponse.IsSuccessStatusCode)
            {
                var venresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Vendedor = JsonConvert.DeserializeObject<Vendedor>(venresponse);
                return Vendedor;
            }
            else
                return null;
        }
        public async Task<Vendedor> ModificarVendedor(Vendedor vendedor)
        {
            string inputJson = Newtonsoft.Json.JsonConvert.SerializeObject(vendedor);
            HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
            httpresponse = await _Clienthttp.PutAsync("vendedor", inputContent);
            if (httpresponse.IsSuccessStatusCode)
            {
                var venresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Vendedor = JsonConvert.DeserializeObject<Vendedor>(venresponse);
                return Vendedor;
            }
            else
                return null;
        }

        public async Task<List<Vendedor>> ListarVendedor()
        {
            try
            {
                httpresponse = await _Clienthttp.GetAsync("vendedor");
                if (httpresponse.StatusCode == HttpStatusCode.OK)
                {
                    var venresponse = httpresponse.Content.ReadAsStringAsync().Result;
                    var _Listavendedorres = JsonConvert.DeserializeObject<List<Vendedor>>(venresponse);
                    return _Listavendedorres;
                }
                
            }
            catch (Exception e)
            {

            }
           return null;
        }

        public async Task<Vendedor> BuscarVendedorporcodigo(string Codigo)
        {
            HttpResponseMessage httpresponse = await _Clienthttp.GetAsync("vendedor/" + Codigo);
            if (httpresponse.StatusCode == HttpStatusCode.OK)
            {
                var venresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var _Vendedor = JsonConvert.DeserializeObject<Vendedor>(venresponse);
                return _Vendedor;
            }
            else
                return null;
        }

        
    }
}
