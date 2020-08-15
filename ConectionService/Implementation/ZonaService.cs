using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using we.app_model.Data;
using we.app_nksystemcore.Utilities;

namespace we.app_nksystemcore.ConectionService.Implementation
{
    public class ZonaService : IZonaService
    {
        private readonly string BaseUrl = "";
        private readonly HttpClient _ClientHttp;
        private readonly IOptions<ConfigurationManager> _ConfigurationService;

        public ZonaService(IOptions<ConfigurationManager> ConfigurationService)
        {
            _ConfigurationService = ConfigurationService;
            BaseUrl = _ConfigurationService.Value.UriBaseApi;
            _ClientHttp = new HttpClient();
        }

        public async Task<List<Zona>> ListarZonas()
        {
            _ClientHttp.BaseAddress = new Uri(BaseUrl);
            _ClientHttp.DefaultRequestHeaders.Clear();
            _ClientHttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpresponse = await _ClientHttp.GetAsync("zona");
            if (httpresponse.StatusCode == HttpStatusCode.OK)
            {
                var zonaresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Zona = JsonConvert.DeserializeObject<List<Zona>>(zonaresponse);
                return Zona;
            }
            else return null;
        }
    }
}
