using Safra.Domain.Entities;
using Safra.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Domain.Services
{
    public class SimulacaoCreditoServices : ISimulacaoCreditoServices
    {
        private ITipoCreditoServices _tipoCreditoServices;
        public SimulacaoCreditoServices(ITipoCreditoServices tipoCreditoServices)
        {
            _tipoCreditoServices = tipoCreditoServices;
        }
        public Task<status_credito> SimularCredito(string tp_pessoa, decimal vl_credito, int tp_credito, int qtd_parcelas, DateTime dt_primeiro_vencimento)
        {
            try
            {
                var tipoCredito = _tipoCreditoServices.Find(tp_credito).Result;

                var retorno = Validacao(tp_pessoa, vl_credito, tipoCredito, qtd_parcelas, dt_primeiro_vencimento);

                return retorno;
            }
            catch (Exception)
            {

                throw new Exception("Ocorreu um erro ao simular o crédito. Tente novamente ou entre em contato com o suporte.");
            }

        }

        private Task<status_credito> Validacao(string tp_pessoa, decimal vl_credito, tab_tipo_credito tp_credito, int qtd_parcelas, DateTime dt_primeiro_vencimento)
        {
            var valid = true;

            if (qtd_parcelas < tp_credito.qtd_min_parcela)
                valid = false;


            if (qtd_parcelas > tp_credito.qtd_max_parcela)
                valid = false;

            if(tp_pessoa.ToLower().Equals("pf"))
            {
                if (vl_credito < tp_credito.vl_min_pf)
                    valid = false;

                if (vl_credito > tp_credito.vl_max_pf)
                    valid = false;
            }
            else
            {
                if (vl_credito > tp_credito.vl_max_pf)
                    valid = false;
            }
            
            if(dt_primeiro_vencimento < DateTime.Now.AddDays(tp_credito.qtd_min_dias_vencimento))
                valid = false;

            if (dt_primeiro_vencimento > DateTime.Now.AddDays(tp_credito.qtd_max_dias_vencimento))
                valid = false;


            double vlEmprestimo = (double)vl_credito;
            double taxa = (((double)tp_credito.taxa) / 100);
            int meses = qtd_parcelas;
            double vlJuros = vlEmprestimo * taxa * meses;
            double S = 0;
            double C = 0;

            var valorTotalPago = vlEmprestimo + vlJuros;
            var valorJurosPago = valorTotalPago - vlEmprestimo;

            vlJuros = 1;
            for (int i = 1; i <= meses; i++)
            {
                vlJuros *= 1 + taxa;
            }

            C = vlEmprestimo + vlJuros;

            Console.WriteLine("Juros Simples =  {0}, juros composto {1}: ", S, C);
            Console.WriteLine("Numero de parcelas juros Simples = {0} ", (S / 12));
            Console.WriteLine("Numero de parcelas juros Composto = {0} ", (C / 12));

            var retorno = new status_credito
            {
                status = valid ? "Aprovado" : "Recusado",
                vl_juros = valorJurosPago.ToString("N2"),
                vl_total_com_juros = valorTotalPago.ToString("N2")
        };

            return Task.Run(()=> retorno);
        }
    }
}
