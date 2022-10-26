using FluentValidation;
using Safra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Domain.Validation.Financiamento
{
    public class FinanciamentoInsert : AbstractValidator<tab_financiamento>
    {
        public FinanciamentoInsert()
        {
            RuleFor(a => a.idCliente)
                .NotEmpty()
                .WithMessage("cliente é campo obrigatorio")
                .NotEqual(0)
                .WithMessage("id do cliente não pode ser 0");

            RuleFor(a => a.idTipoCredito)
                    .NotEmpty()
                    .WithMessage("tipo de crédito é campo obrigatorio")
                    .NotEqual(0)
                    .WithMessage("id do tipo de crédito não pode ser 0");

            RuleFor(a => a.vl_total)
                .NotEqual(0)
                .WithMessage("valor total é campo obrigatorio");

            RuleFor(a => a.dt_ultimo_vencimento)
                .NotEmpty().WithMessage("campo obrigatório")
                .LessThan(p => DateTime.Now).WithMessage("a data deve estar no passado");

        }

    }
}
