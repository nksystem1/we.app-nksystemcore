using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.appcore_nksystem.Models;

namespace we.app_nksystemcore.ConectionService
{
    public interface INegocioService
    {
        Task<List<Negocio>> ListarEmpresa();
    }
}
