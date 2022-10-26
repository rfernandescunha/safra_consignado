using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Application.ViewModels.Cliente
{
    public class ClienteViewModelPutResult
    {
        [DisplayName("Id")]
        public int idCliente { get; set; }

        [DisplayName("Nome")]
        public string nome { get; set; }
        [DisplayName("Cpf/Cnpj")]
        public string cpf_cnpj { get; set; }
        [DisplayName("UF")]
        public string uf { get; set; }
        [DisplayName("Celular")]
        public string celular { get; set; }
        [DisplayName("Tipo Pessoa")]
        public string tp_pessoa { get; set; }
        [DisplayName("Dt. Cadastro")]
        public DateTime dt_cadastro { get; set; }
    }
}
