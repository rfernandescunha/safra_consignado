using AutoMapper;
using Safra.Application.Interfaces;
using Safra.Application.ViewModels.SimulacaoCredito;
using Safra.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Application.Services
{
    public class SimulacaoCreditoAppServices : ISimulacaoCreditoAppServices
    {
        private readonly IMapper _mapper;
        private readonly ISimulacaoCreditoServices _productServices;
        public SimulacaoCreditoAppServices(
                                        ISimulacaoCreditoServices productServices,
                                        IMapper mapper)
        {
            _mapper = mapper;
            _productServices = productServices;
        }
        public async Task<SimulacaoCreditoViewModelPostResult> SimularCredito(SimulacaoCreditoViewModelPost post)
        {
            var result = await _productServices.SimularCredito(post.tp_pessoa, post.vl_credito, post.tp_credito, post.qtd_parcelas, post.dt_primeiro_vencimento);

            var retorno = _mapper.Map<SimulacaoCreditoViewModelPostResult>(result);

            return retorno;
        }
    }
}
