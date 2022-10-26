using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Safra.Application.ViewModels.SimulacaoCredito
{
    public class SimulacaoCreditoViewModelPost
    {
        [Required]
        [DisplayName("Tipo Pessoa")]
        public string tp_pessoa { get; set; }

        [Required]
        [DisplayName("Valor do Crédito")]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Valor do crédito inválido")]
        public decimal vl_credito { get; set; }
        [Required]
        [DisplayName("Tipo do Crédito")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Tipo de crédito inválido")]
        public int tp_credito { get; set; }
        [Required]
        [DisplayName("Qtd de Parcelas")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Quantidade de parcela inválido")]
        public int qtd_parcelas { get; set; }
        [Required]
        [DisplayName("Dt. Primeiro Vencimento")]
        public DateTime dt_primeiro_vencimento { get; set; }
    }
}
