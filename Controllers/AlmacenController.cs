using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace we.app_nksystemcore.Controllers
{
    public class AlmacenController : Controller
    {
        
        public ActionResult ListarAlmacen()
        {
            
                return View();
         }

        public ActionResult NuevoAlmacen()
        {
            return View();
        }

        public ActionResult CrearAlmacenAsync(){
            
            return RedirectToAction("ListarAlmacen");
        }
    }
}