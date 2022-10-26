using Safra.Application.ViewModels.TipoCredito;
using Safra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Application.Interfaces
{
    public interface ITipoCreditoAppServices
    {
        //Task<ClienteViewModelPostResult> Insert(ClienteViewModelPost item);
        //Task<ClienteViewModelPutResult> Update(ClienteViewModelPut item);
        //Task<bool> Delete(int Id);
        Task<TipoCreditoViewModelFindResult> Find(int Id);
        Task<IEnumerable<TipoCreditoViewModelFindAllResult>> Find(Expression<Func<tab_tipo_credito, bool>> predicate = null);
    }
}
