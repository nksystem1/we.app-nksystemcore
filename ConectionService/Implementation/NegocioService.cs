using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using we.app_nksystemcore.Utilities;
using web.appcore_nksystem.Models;

namespace we.app_nksystemcore.ConectionService.Implementation
{
    public class NegocioService : INegocioService
    {
        private readonly string BaseUrl = "";
        private readonly HttpClient _Clienthttp;
        private readonly IOptions<ConfigurationManager> _ConfigurationService;
        public NegocioService(IOptions<ConfigurationManager> configservice)
        {
            _ConfigurationService = configservice;
            BaseUrl = _ConfigurationService.Value.UriBaseApi;
            _Clienthttp = new HttpClient();
        }
        public async Task<List<Negocio>> ListarEmpresa()
        {
            _Clienthttp.BaseAddress = new Uri(BaseUrl);
            _Clienthttp.DefaultRequestHeaders.Clear();
            _Clienthttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpresponse = await _Clienthttp.GetAsync("negocio");
            if (httpresponse.StatusCode == HttpStatusCode.OK)
            {
                var empresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var _Listaempresas = JsonConvert.DeserializeObject<List<Negocio>>(empresponse);
                return _Listaempresas;
            }
            else
                return null;

        }
    }
}
