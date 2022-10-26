using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Application.ViewModels.Cliente
{
    public class ClienteViewModelPut : BaseViewModels
    {
        [Key]
        public int idCliente { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Nome")]
        public string nome { get; set; }
        [Required]
        [StringLength(14)]
        [DisplayName("Cpf/Cnpj")]
        public string cpf_cnpj { get; set; }
        [Required]
        [StringLength(2)]
        [DisplayName("UF")]
        public string uf { get; set; }
        [Required]
        [StringLength(11)]
        [DisplayName("Celular")]
        public string celular { get; set; }
        [Required]
        [StringLength(1)]
        [DisplayName("Tipo Pessoa")]
        public string tp_pessoa { get; set; }

    }
}
