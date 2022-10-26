using Microsoft.Extensions.DependencyInjection;
using Safra.Application.Interfaces;
using Safra.Application.Services;
using Safra.Domain.Interfaces.IServices;
using Safra.Domain.Services;

namespace Safra.Infra.CrossCutting.Ioc
{
    public static class InjectionService
    {
        public static void Register(IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IClienteAppServices, ClienteAppServices>();
            serviceCollection.AddTransient<ITipoCreditoAppServices, TipoCreditoAppServices>();
            serviceCollection.AddTransient<ISimulacaoCreditoAppServices, SimulacaoCreditoAppServices>();


            serviceCollection.AddTransient<IClienteServices, ClienteServices>();
            serviceCollection.AddTransient<IFinanciamentoServices, FinanciamentoServices>();
            serviceCollection.AddTransient<IParcelaServices, ParcelaServices>();
            serviceCollection.AddTransient<ITipoCreditoServices, TipoCreditoServices>();
            serviceCollection.AddTransient<ISimulacaoCreditoServices, SimulacaoCreditoServices>();
        }
    }
}
