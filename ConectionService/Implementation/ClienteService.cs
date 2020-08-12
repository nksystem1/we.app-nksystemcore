using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using we.app_nksystemcore.Utilities;
using web.appcore_nksystem.Models;

namespace we.app_nksystemcore.ConectionService.Implementation
{
    public class ClienteService : IClienteService
    {
        private readonly HttpClient _ClientHttp;
        HttpResponseMessage httpresponse;
        private readonly string BaseUrl = "";
        private readonly IOptions<ConfigurationManager> _CondigurationService;

        public ClienteService(IOptions<ConfigurationManager> ConfiguratonService)
        {
            _CondigurationService = ConfiguratonService;
            BaseUrl = _CondigurationService.Value.UriBaseApi;
            _ClientHttp = new HttpClient();
            _ClientHttp.BaseAddress = new Uri(BaseUrl);
            _ClientHttp.DefaultRequestHeaders.Clear();
            _ClientHttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            try
            {
                httpresponse = await _ClientHttp.GetAsync("cliente");
                if (httpresponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var clienteresponse = httpresponse.Content.ReadAsStringAsync().Result;
                    var Lstclientes = JsonConvert.DeserializeObject<List<Cliente>>(clienteresponse);
                    return Lstclientes;
                }
                
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return null;
        }
    }
}
