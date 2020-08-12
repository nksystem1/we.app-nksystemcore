using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using we.app_nksystemcore.Models;
using we.app_nksystemcore.Utilities;

namespace we.app_nksystemcore.ConectionService.Implementation
{
    public class UsuarioService : IUsuarioService
    {
        private readonly string BaseUrl = "";
        private readonly HttpClient _ClienteHttp;
        private readonly IOptions<ConfigurationManager> _ConfogurationService;
        public UsuarioService(IOptions<ConfigurationManager> ConfogurationService)
        {
            _ConfogurationService = ConfogurationService;
            BaseUrl = _ConfogurationService.Value.UriBaseApi;
            _ClienteHttp = new HttpClient();
            _ClienteHttp.BaseAddress = new Uri(BaseUrl);
            _ClienteHttp.DefaultRequestHeaders.Clear();
            _ClienteHttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Usuario>> ListarUsuario()
        {
            HttpResponseMessage httpresponse = await _ClienteHttp.GetAsync("usuario");
            if (httpresponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var usuarioresponse = httpresponse.Content.ReadAsStringAsync().Result;
                var Usuario = JsonConvert.DeserializeObject<List<Usuario>>(usuarioresponse);
                return Usuario;
            }
            else return null;
        }
    }
}
