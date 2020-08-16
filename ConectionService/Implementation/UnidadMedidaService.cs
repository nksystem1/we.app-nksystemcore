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
    public class UnidadMedidaService : IUnidadMedidaService
    {
        private readonly string BaseUrl = "";
        private readonly HttpClient _Clienthttp;
        private readonly IOptions<ConfigurationManager> _ConfiguratonService;
        HttpResponseMessage httpresponse;

        public UnidadMedidaService(IOptions<ConfigurationManager> ConfiguratonService)
        {
            _ConfiguratonService = ConfiguratonService;
            BaseUrl = _ConfiguratonService.Value.UriBaseApi;
            _Clienthttp = new HttpClient();
            _Clienthttp.BaseAddress = new Uri(BaseUrl);
            _Clienthttp.DefaultRequestHeaders.Clear();
            _Clienthttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<UnidadMedida> BuscarUnidadporcodigo(string Codigo)
        {
            HttpResponseMessage httpresponse = await _Clienthttp.GetAsync("unidadmedida/" + Codigo);
            if (httpresponse.StatusCode == HttpStatusCode.OK)
            {
                var uniresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var _Unidad = JsonConvert.DeserializeObject<UnidadMedida>(uniresponse);
                return _Unidad;
            }
            else
                return null;
        }

        public async Task<UnidadMedida> GuardarUnidadMedida(UnidadMedida unidad)
        {
            string inputJson = Newtonsoft.Json.JsonConvert.SerializeObject(unidad);
            HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
            httpresponse = await _Clienthttp.PostAsync("unidadmedida", inputContent);
            if (httpresponse.IsSuccessStatusCode)
            {
                var uniresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Unidad = JsonConvert.DeserializeObject<UnidadMedida>(uniresponse);
                return Unidad;
            }
            else
                return null;
        }

        public async Task<List<UnidadMedida>> ListarUnidades()
        {
            try
            {
                httpresponse = await _Clienthttp.GetAsync("unidadmedida");
                if (httpresponse.StatusCode == HttpStatusCode.OK)
                {
                    var uniresponse = httpresponse.Content.ReadAsStringAsync().Result;
                    var _Listaunidades = JsonConvert.DeserializeObject<List<UnidadMedida>>(uniresponse);
                    return _Listaunidades;
                }

            }
            catch (Exception e)
            {

            }
            return null;
        }

        public async Task<UnidadMedida> ModificarUnidadMedida(UnidadMedida unidad)
        {
            string inputJson = Newtonsoft.Json.JsonConvert.SerializeObject(unidad);
            HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
            httpresponse = await _Clienthttp.PutAsync("unidadmedida", inputContent);
            if (httpresponse.IsSuccessStatusCode)
            {
                var uniresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Unidad = JsonConvert.DeserializeObject<UnidadMedida>(uniresponse);
                return Unidad;
            }
            else
                return null;
        }
    }
}
