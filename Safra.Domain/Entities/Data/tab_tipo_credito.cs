﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Safra.Domain.Entities
{
    public partial class tab_tipo_credito : BaseEntity
    {
        public tab_tipo_credito()
        {
            tab_financiamento = new HashSet<tab_financiamento>();
        }

        public int idTipoCredito { get; set; }
        public string tp_credito { get; set; }
        public int taxa { get; set; }
        public int qtd_min_parcela { get; set; }
        public int qtd_max_parcela { get; set; }
        public decimal vl_min_pf { get; set; }
        public decimal? vl_max_pf { get; set; }
        public decimal? vl_min_pj { get; set; }
        public decimal? vl_max_pj { get; set; }
        public int qtd_min_dias_vencimento { get; set; }
        public int qtd_max_dias_vencimento { get; set; }

        public virtual ICollection<tab_financiamento> tab_financiamento { get; set; }
    }
}