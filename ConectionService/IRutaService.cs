using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using we.app_nksystemcore.Models;

namespace we.app_nksystemcore.ConectionService
{
    public interface IRutaService
    {
        Task<List<Ruta>> ListarRutas();
        Task<Ruta> GuardarRuta(Ruta Ruta);
        Task<Ruta> BuescarRutaPorCodigo(string Codigo);
        Task<Ruta> ModificarRuta(Ruta Ruta);
    }
}
