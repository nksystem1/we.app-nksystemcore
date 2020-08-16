using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using we.app_model.Data;

namespace we.app_nksystemcore.ConectionService
{
    public interface IUnidadMedidaService
    {
        Task<List<UnidadMedida>> ListarUnidades();
        Task<UnidadMedida> GuardarUnidadMedida(UnidadMedida unidad);
        Task<UnidadMedida> ModificarUnidadMedida(UnidadMedida unidad);
        Task<UnidadMedida> BuscarUnidadporcodigo(string Codigo);
    }
}
