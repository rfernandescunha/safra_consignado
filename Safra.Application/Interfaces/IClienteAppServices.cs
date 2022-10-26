using Safra.Application.ViewModels.Cliente;
using Safra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Application.Interfaces
{
    public interface IClienteAppServices
    {
        Task<ClienteViewModelPostResult> Insert(ClienteViewModelPost item);
        Task<ClienteViewModelPutResult> Update(ClienteViewModelPut item);
        Task<bool> Delete(int Id);
        Task<ClienteViewModelFindResult> Find(int Id);
        Task<IEnumerable<ClienteViewModelFindAllResult>> Find(Expression<Func<tab_cliente, bool>> predicate = null);
    }
}
