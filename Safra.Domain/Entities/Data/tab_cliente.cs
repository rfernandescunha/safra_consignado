﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Safra.Domain.Entities
{
    public partial class tab_cliente: BaseEntity
    {
        public tab_cliente()
        {
            tab_financiamento = new HashSet<tab_financiamento>();
        }

        public int idCliente { get; set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string uf { get; set; }
        public string celular { get; set; }
        public string tp_pessoa { get; set; }
        public DateTime dt_cadastro { get; set; }

        public virtual ICollection<tab_financiamento> tab_financiamento { get; set; }
    }
}