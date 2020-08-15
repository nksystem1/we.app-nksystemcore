using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using we.app_nksystemcore.ConectionService;
using we.app_model.Data;
using we.app_nksystemcore.Report;

namespace we.app_nksystemcore.Controllers
{
    public class RutaController : Controller
    {
        private readonly IRutaService _RutaService;
        private readonly IZonaService _ZonaService;
        private readonly IVendedorService _VendedorService;
        private IConverter _converter;
        IWebHostEnvironment _env;
        public RutaController(IRutaService RutaService, IZonaService ZonaService, IVendedorService VendedorService, IConverter converter, IWebHostEnvironment env)
        {
            _RutaService = RutaService;
            _ZonaService = ZonaService;
            _VendedorService = VendedorService;
            _converter = converter;
            _env = env;
        }
        public async Task<IActionResult> ListarRuta()
        {
            var _LstRutas = await _RutaService.ListarRutas();
            if (_LstRutas == null)
            {
                return View(new List<Ruta>());
            }
            else
            {
                return View(_LstRutas);
            }
        }

        public async Task<IActionResult> MostrarRuta(string RutaId)
        {
            Ruta ruta = await _RutaService.BuescarRutaPorCodigo(RutaId);
            if (ruta != null)
            {
                return View(ruta);
            }
            else
            {
                return View(new Ruta());
            }           
        }

        public async Task<IActionResult> VerificarRutaExiste(String CodigoIn)
        {
            Ruta ruta = await _RutaService.BuescarRutaPorCodigo(CodigoIn);
            if (ruta != null)
            {
                var result = new { Success = false, Message = "Error Message" };
                return new JsonResult(result);
            }
            else
            {
                var result = new { Success = true, Message = "Succes Message", };
                return new JsonResult(result);
            }
        }

        public async Task<IActionResult> CrearRuta()
        {
            ViewBag.Zonas = await _ZonaService.ListarZonas();
            ViewBag.Vendedores = await _VendedorService.ListarVendedor();
            return View(new Ruta());
        }

        public async Task<IActionResult> GuardarRuta(string CodigoIn, string NombreIn, string vendedorId, string Desde1, string Hasta1, string Desde2, string Hasta2, int Codzona)
        {
            var RutaObj = new Ruta()
            {
                codigo = CodigoIn,
                nombre = NombreIn,
                codigozona = Codzona,
                desdeuno = Desde1,
                hastauno = Hasta1,
                desdedos = Desde2,
                hastados = Hasta2,
                codigovendedor = vendedorId,
                codnegocio = "901001195-0",
            };
            Ruta _Rutas = await _RutaService.GuardarRuta(RutaObj);
            if (_Rutas == null)
            {
                var result = new { Success = false, Message = "Error Message" };
                return new JsonResult(result);
            }
            else
            {
                var result = new { Success = true, Message = "Succes Message", };
                return new JsonResult(result);
            }
        }

        public async Task<IActionResult> ModificarRuta(string CodigoIn, string NombreIn, string vendedorId, string Desde1, string Hasta1, string Desde2, string Hasta2, int Codzona)
        {
            var RutaObj = new Ruta()
            {
                codigo = CodigoIn,
                nombre = NombreIn,
                codigozona = Codzona,
                desdeuno = Desde1,
                hastauno = Hasta1,
                desdedos = Desde2,
                hastados = Hasta2,
                codigovendedor = vendedorId,
                codnegocio = "901001195-0",
            };
            Ruta _Rutas = await _RutaService.ModificarRuta(RutaObj);
            if (_Rutas == null)
            {
                var result = new { Success = false, Message = "Error Message" };
                return new JsonResult(result);
            }
            else
            {
                var result = new { Success = true, Message = "Succes Message", };
                return new JsonResult(result);
            }
        }

        public async Task<IActionResult> EditarRuta(string RutaId)
        {
            ViewBag.Zonas = await _ZonaService.ListarZonas();
            ViewBag.Vendedores = await _VendedorService.ListarVendedor();
            Ruta Ruta= await _RutaService.BuescarRutaPorCodigo(RutaId);
            if (Ruta != null)
            {
                return View(Ruta);
            }
            else
            {
                return View(new Ruta());
            }
        }

        public async Task<IActionResult> Invoice()
        {
            string path = Path.Combine(_env.ContentRootPath, "Report", "Rutas.html");
            Ruta ruta = await _RutaService.BuescarRutaPorCodigo("02");
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4Plus,
                DocumentTitle = "Invoice",

            },
                Objects = {
                    new ObjectSettings() {
                    HtmlContent = RutaParser.Parse(path,ruta),
                    WebSettings = { DefaultEncoding = "utf-8" },
                    }
                }
            };
            byte[] pdf = _converter.Convert(doc);
            return new FileContentResult(pdf, "application/pdf");
        }
    }
}