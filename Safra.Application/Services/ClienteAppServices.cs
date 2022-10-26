using AutoMapper;
using Safra.Application.Interfaces;
using Safra.Application.ViewModels.Cliente;
using Safra.Domain.Entities;
using Safra.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Application.Services
{
    public class ClienteAppServices : IClienteAppServices
    {
        private readonly IMapper _mapper;
        private readonly IClienteServices _productServices;

        public ClienteAppServices(
                                                IClienteServices productServices,
                                                IMapper mapper)
        {
            _mapper = mapper;
            _productServices = productServices;
        }

        public async Task<bool> Delete(int Id)
        {
            return await _productServices.Delete(Id);
        }

        public async Task<IEnumerable<ClienteViewModelFindAllResult>> Find(Expression<Func<tab_cliente, bool>> predicate = null)
        {
            var retorno = await _productServices.Find(predicate);

            return _mapper.Map<IEnumerable<ClienteViewModelFindAllResult>>(retorno);
        }

        public async Task<ClienteViewModelFindResult> Find(int Id)
        {

            var item = await _productServices.Find(Id);

            return _mapper.Map<ClienteViewModelFindResult>(item);
        }

        public async Task<ClienteViewModelPostResult> Insert(ClienteViewModelPost Objeto)
        {
            var entrada = _mapper.Map<tab_cliente>(Objeto);

            var retorno = await _productServices.Insert(entrada);

            return _mapper.Map<ClienteViewModelPostResult>(retorno);
        }

        public async Task<ClienteViewModelPutResult> Update(ClienteViewModelPut Objeto)
        {
            var entrada = _mapper.Map<tab_cliente>(Objeto);

            var retorno = await _productServices.Update(entrada);

            return _mapper.Map<ClienteViewModelPutResult>(retorno);
        }
    }
}
