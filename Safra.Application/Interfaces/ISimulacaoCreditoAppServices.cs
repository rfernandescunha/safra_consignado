using Safra.Application.ViewModels.SimulacaoCredito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Application.Interfaces
{
    public interface ISimulacaoCreditoAppServices
    {
        Task<SimulacaoCreditoViewModelPostResult> SimularCredito(SimulacaoCreditoViewModelPost post);
    }
}
