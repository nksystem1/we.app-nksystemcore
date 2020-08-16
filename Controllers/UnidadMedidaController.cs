using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using we.app_model.Data;
using we.app_nksystemcore.ConectionService;

namespace we.app_nksystemcore.Controllers
{
    public class UnidadMedidaController: Controller
    {
        private readonly IUnidadMedidaService _UnidadService;
        public UnidadMedidaController(IUnidadMedidaService UnidadService)
        {
            _UnidadService = UnidadService;
        }

        public async Task<IActionResult> ListarUnidades()
        {
            List<UnidadMedida> _Listaunidades = await _UnidadService.ListarUnidades();
            if (_Listaunidades == null)
                return View(new List<UnidadMedida>());
            else
                return View(_Listaunidades);
        }
    }
}
