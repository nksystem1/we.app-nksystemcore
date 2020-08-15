using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using we.app_model.Data;

namespace we.app_nksystemcore.ConectionService
{
    public interface IVendedorService
    {
        Task<List<Vendedor>> ListarVendedor();
        Task<Vendedor> GuardarVendedor(Vendedor vendedor);
        Task<Vendedor> ModificarVendedor(Vendedor vendedor);
        Task<Vendedor> BuscarVendedorporcodigo(string Codigo);
    }
}
