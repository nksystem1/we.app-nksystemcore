using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using we.app_nksystemcore.ConectionService;
using we.app_model.Data;

namespace we.app_nksystemcore.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _ClienteService;

        public ClienteController(IClienteService ClienteService)
        {
            _ClienteService = ClienteService;
        }
        public async Task<ActionResult> ListarCliente()
        {
            var _Lstclientes = await _ClienteService.ListarClientes();
            if (_Lstclientes == null)
            {
                return View(new List<Cliente>());
            }
            else
            {
                return View(_Lstclientes);
            }
        }

        public IActionResult CrearCliente()
        {
            return View();
        }
    }
}