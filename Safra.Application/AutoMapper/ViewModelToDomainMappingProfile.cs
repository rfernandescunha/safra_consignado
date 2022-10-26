
using AutoMapper;
using Safra.Application.ViewModels.Cliente;
using Safra.Domain.Entities;

namespace Safra.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            CreateMap<ClienteViewModelPost, tab_cliente>();
            CreateMap<ClienteViewModelPut, tab_cliente>();

        }
    }
}
