using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using we.app_nksystemcore.ConectionService;
using we.app_model.Data;

namespace we.app_nksystemcore.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _UsuarioService;
        public UsuarioController(IUsuarioService UsuarioService)
        {
            _UsuarioService = UsuarioService;
        }
        public async Task<IActionResult> ListarUsuario()
        {
           var LstUsuarios = await _UsuarioService.ListarUsuario();
            if (LstUsuarios == null)
            {
                return View(new List<Usuario>());
            }
            else
            {
                return View(LstUsuarios);
            }
        }
    }
}
