using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using we.app_nksystemcore.Models;

namespace we.app_nksystemcore.ConectionService
{
    public interface IZonaService
    {
        Task<List<Zona>> ListarZonas();
    }
}
