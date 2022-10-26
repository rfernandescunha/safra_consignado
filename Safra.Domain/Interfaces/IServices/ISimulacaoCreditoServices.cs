using Safra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Domain.Interfaces.IServices
{
    public interface ISimulacaoCreditoServices
    {
        Task<status_credito> SimularCredito(string tp_pessoa, decimal vl_credito, int tp_credito, int qtd_parcelas, DateTime dt_primeiro_vencimento);
    }
}
