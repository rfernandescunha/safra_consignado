using FluentValidation;
using Safra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Domain.Validation.Cliente
{
    public class ClienteUpdate : AbstractValidator<tab_cliente>
    {
        public ClienteUpdate()
        {
            RuleFor(a => a.idCliente)
                .NotEmpty()
                .WithMessage("Id é campo obrigatorio")
                .NotEqual(0)
                .WithMessage("Id não pode ser 0");

            RuleFor(a => a.nome)
                .NotEmpty()
                .WithMessage("nome é campo obrigatorio")
                .MaximumLength(100)
                .WithMessage("Nome deve conter 100 no maximo caracteres")
                .MinimumLength(10)
                .WithMessage("Nome deve conter 10 no minimo caracteres");

            RuleFor(a => a.cpf_cnpj)
                .NotEmpty()
                .WithMessage("cpf é campo obrigatorio")
                .MaximumLength(11)
                .WithMessage("cpf deve conter 11 no maximo caracteres")
                .MinimumLength(11)
                .WithMessage("cpf deve conter 11 no minimo caracteres");

            RuleFor(a => a.uf)
                .NotEmpty()
                .WithMessage("Estado é campo obrigatorio")
                .MaximumLength(2)
                .WithMessage("Estado deve conter 2 no maximo caracteres")
                .MinimumLength(2)
                .WithMessage("Estado deve conter 2 no minimo caracteres");

            RuleFor(a => a.celular)
                .NotEmpty()
                .WithMessage("Celular é campo obrigatorio");

            RuleFor(a => a.tp_pessoa)
                .NotEmpty()
                .WithMessage("Tipo de pessoa é campo obrigatorio");

        }

    }
}
