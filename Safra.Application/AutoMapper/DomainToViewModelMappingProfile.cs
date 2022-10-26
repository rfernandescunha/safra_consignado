using AutoMapper;
using Safra.Domain.Entities;
using Safra.Application.ViewModels.Cliente;
using Safra.Application.ViewModels.TipoCredito;
using Safra.Application.ViewModels.SimulacaoCredito;

namespace Safra.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<tab_cliente, ClienteViewModelFindAllResult>();
            CreateMap<tab_cliente, ClienteViewModelFindResult>();

            CreateMap<tab_tipo_credito, TipoCreditoViewModelFindResult>();
            CreateMap<tab_tipo_credito, TipoCreditoViewModelFindAllResult>();


            CreateMap<status_credito, SimulacaoCreditoViewModelPostResult>();
        }
    }
}
