using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using we.app_model.Data;

namespace we.app_nksystemcore.ConectionService
{
    public interface IClienteService
    {
        Task<List<Cliente>> ListarClientes();
    }
}
