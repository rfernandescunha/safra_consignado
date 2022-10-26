using FluentValidation;
using Safra.Domain.Entities;

namespace Safra.Domain.Validation.TipoCredito
{
    public class TipoCreditoInsert : AbstractValidator<tab_tipo_credito>
    {
        public TipoCreditoInsert()
        {
            RuleFor(a => a.tp_credito)
                .NotEmpty()
                .WithMessage("nome é campo obrigatorio")
                .MaximumLength(100)
                .WithMessage("Nome deve conter 50 no maximo caracteres")
                .MinimumLength(10)
                .WithMessage("Nome deve conter 10 no minimo caracteres");

            RuleFor(a => a.taxa)
                .NotEqual(0)
                .WithMessage("taxa é campo obrigatorio");

            RuleFor(a => a.qtd_min_parcela)
                .NotEqual(0)
                .WithMessage("quantidade minima de parcela é campo obrigatorio");

            RuleFor(a => a.qtd_max_parcela)
                .NotEqual(0)
                .WithMessage("quantidade maxima de parcela é campo obrigatorio");


            RuleFor(a => a.vl_min_pf)
                .NotEqual(0)
                .WithMessage("valor minimo é campo obrigatorio");

            RuleFor(a => a.qtd_min_dias_vencimento)
                .NotEqual(0)
                .WithMessage("quantidade minima de dias é campo obrigatorio");

            RuleFor(a => a.qtd_max_dias_vencimento)
                .NotEqual(0)
                .WithMessage("quantidade maxima de dias é campo obrigatorio");

        }

    }
}
