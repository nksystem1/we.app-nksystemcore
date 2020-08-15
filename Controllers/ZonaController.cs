using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using we.app_nksystemcore.ConectionService;
using we.app_model.Data;

namespace we.app_nksystemcore.Controllers
{
    public class ZonaController : Controller
    {
        private readonly IZonaService _ZonaService;
        public ZonaController(IZonaService ZonaService)
        {
            _ZonaService = ZonaService;
        }
        public async Task<IActionResult> ListarZonas()
        {
            var _LstZonas = await _ZonaService.ListarZonas();
            if (_LstZonas == null) {
                return View(new List<Zona>());
            }
            else
            {
                return View(_LstZonas);
            }            
        }

        public IActionResult CrearZona()
        {
            Zona Zona = new Zona();
            return View(Zona);
        }

        public IActionResult MostrarZona(int ZonaId)
        {
            return View();
        }
    }
}