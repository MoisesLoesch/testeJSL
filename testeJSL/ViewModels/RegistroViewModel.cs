using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testeJSL.ViewModels
{
    public class RegistroViewModel
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string primeiroNome { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string segundoNome { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string marca { get; set; }

        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string modelo { get; set; }

        [Display(Name = "Placa")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "Use menos caracteres")]
        [MinLength(7, ErrorMessage = "Placa não permitida")]
        public string placa { get; set; }

        [Display(Name = "Eixos")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string eixos { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string nomeEndereco { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string bairro { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string cidade { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "Use menos caracteres")]
        [MinLength(8, ErrorMessage = "CEP não permitido")]
        public string cep { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string numero { get; set; }

        [Display(Name = "Complemento")]
        public string complemento { get; set; }
    }
}
