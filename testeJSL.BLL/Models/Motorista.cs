using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace testeJSL.BLL.Models
{
    public class Motorista : IdentityUser<string>
    {
        
        public string primeiroNome { get; set; }
        public string segundoNome { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }

        public virtual ICollection<Endereco> Endereco {get; set; }

    }
}
