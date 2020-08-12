using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace we.app_nksystemcore.Controllers
{
    public class FamiliaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
