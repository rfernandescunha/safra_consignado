using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Application.ViewModels.TipoCredito
{
    public class TipoCreditoViewModelFindAllResult
    {
        [DisplayName("Id")]
        public int idTipoCredito { get; set; }
        [DisplayName("Tipo de Crédito")]
        public string tp_credito { get; set; }
        [DisplayName("Taxa")]
        public int taxa { get; set; }
        [DisplayName("Qtd Min. Parcela")]
        public int qtd_min_parcela { get; set; }
        [DisplayName("Qtd Max. Parcela")]
        public int qtd_max_parcela { get; set; }
        [DisplayName("Valor Min. Pf")]
        public decimal vl_min_pf { get; set; }
        [DisplayName("Valor Max. Pf")]
        public decimal? vl_max_pf { get; set; }
        [DisplayName("Valor Min. Pj")]
        public decimal? vl_min_pj { get; set; }
        [DisplayName("Valor Max. Pj")]
        public decimal? vl_max_pj { get; set; }
        [DisplayName("Qtd Min. Dias Venciamento")]
        public int qtd_min_dias_vencimento { get; set; }
        [DisplayName("Qtd Max. Dias Venciamento")]
        public int qtd_max_dias_vencimento { get; set; }
    }
}
