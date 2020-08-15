using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using we.app_nksystemcore.ConectionService;
using we.app_model.Data;

namespace we.app_nksystemcore.Controllers
{
    public class VendedorController : Controller
    {
        private readonly IVendedorService _VendedorService;
        public VendedorController(IVendedorService VendedorService)
        {
            _VendedorService = VendedorService;
        }
        public async Task<IActionResult> ListarVendedor()
        {
            List<Vendedor> _Listavendedores = await _VendedorService.ListarVendedor();
            if (_Listavendedores == null)
                return View(new List<Vendedor>());
            else
                return View(_Listavendedores);
        }

        public IActionResult CrearVendedor()
        {
            return View(new Vendedor());
        }

        [HttpPost]
        public async Task<IActionResult> GuardarVendedor(string Codigo, string Nombre, string Interno, string Cobrador, string Direccionfiscal, string Correoe, List<Comision> LstComisiones, string Montometa)
        {
            double Montometaconvert = 0;
            try
            {
                Montometaconvert = double.Parse(Montometa);
            }
            catch (Exception e)
            {
                Montometaconvert = 0;
            }
            var Objvendedor = new Vendedor()
            {
                codigo = Codigo,
                nombre = Nombre,
                interno = Interno,
                cobrador = Cobrador,
                direccionfiscal = Direccionfiscal,
                correoe = Correoe,
                codnegocio = "901001195-0",
                codzona = 9,
                codusuario = "admin",
                lstComisiones = LstComisiones,
                montometa = Montometaconvert
            };
            
            Vendedor _Vendedores = await _VendedorService.GuardarVendedor(Objvendedor);
            if (_Vendedores == null)
            {
                var result = new { Success = false, Message = "Error Message" };
                return new JsonResult(result);
            }
            else
            {
                var result = new { Success = true, Message = "Succes Message",  };
                return new JsonResult(result);               
            }
        }

        public async Task<IActionResult> ModificarVendedor(string vendedorId)
        {
            var Vendedor = await _VendedorService.BuscarVendedorporcodigo(vendedorId);
            if (Vendedor == null)
            {
                return View(new Vendedor());
            }
            else
            {
                return View(Vendedor);
            }
        }

        public async Task<IActionResult> ActualizarVendedor(string Codigo, string Nombre, string Interno, string Cobrador, string Direccionfiscal, string Correoe, List<Comision> LstComisiones, string Montometa)
        {
            double Montometaconvert = 0;
            try
            {
                Montometaconvert = double.Parse(Montometa);
            }
            catch (Exception e)
            {
                Montometaconvert = 0;
            }
            var Objvendedor = new Vendedor()
            {
                codigo = Codigo,
                nombre = Nombre,
                interno = Interno,
                cobrador = Cobrador,
                direccionfiscal = Direccionfiscal,
                correoe = Correoe,
                codnegocio = "901001195-0",
                codzona = 9,
                codusuario = "admin",
                lstComisiones = LstComisiones,
                montometa = Montometaconvert
            };

            Vendedor _Vendedores = await _VendedorService.ModificarVendedor(Objvendedor);
            if (_Vendedores == null)
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



        public IActionResult AgregarComision(string porcinf, string porsup, string porccom)
        {
            //string json = Forms[0].ToString();
            return View();
        }

        public async Task<IActionResult> MostrarVendedor(string vendedorId) 
        {
            var Vendedor = await _VendedorService.BuscarVendedorporcodigo(vendedorId);
            if (Vendedor == null)
            {
                return View();
            }
            else
            {
                return View(Vendedor);
            }
            
        }
    }
}