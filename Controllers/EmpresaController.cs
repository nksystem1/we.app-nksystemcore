using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using we.app_nksystemcore.ConectionService;
using we.app_nksystemcore.ConectionService.Implementation;
using we.app_model.Data;


namespace web.appcore_nksystem.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly INegocioService _NegocioService;
        public EmpresaController(INegocioService NegocioService)
        {
            _NegocioService = NegocioService;
        }
        public async Task<IActionResult> ListarEmpresa()
        {
            List<Negocio> _Listaempresas = await _NegocioService.ListarEmpresa();
            if (_Listaempresas == null)
                return RedirectToAction("Error", "Home");
            else
                return View(_Listaempresas);
        }

        public IActionResult CrearEmpresa()
        {
            var Empresa = new Negocio()
            {

            };
            return View(Empresa);
        }
    }
}