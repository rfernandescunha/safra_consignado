using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Safra.Domain.Interfaces.IRepository;
using Safra.Infra.Data;
using Safra.Infra.Data.Repositories;

namespace Safra.Infra.CrossCutting.Ioc
{
    public static class InjectionRepository
    {
        public static void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));


            serviceCollection.AddScoped<IClienteRepository, ClienteRepository>();
            serviceCollection.AddScoped<IFinanciamentoRepository, FinanciamentoRepository>();
            serviceCollection.AddScoped<IParcelaRepository, ParcelaRepository>();
            serviceCollection.AddScoped<ITipoCreditoRepository, TipoCreditoRepository>();


            var sqlDbSettings = configuration.GetSection("SqlConfiguration");

            serviceCollection.AddDbContext<SafraContext>(
                options => options.UseSqlServer(sqlDbSettings.GetSection("ConnectionString").Value)
            );
        }
    }
}
