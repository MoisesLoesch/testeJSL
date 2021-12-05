using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace testeJSL.BLL.Models
{
    public class Endereco
    {
        public int id_Endereco { get; set; }

        public string nomeEndereco { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string cep { get; set; }

        public string numero { get; set; }

        public string complemento { get; set; }

        public string id_Motorista { get; set; }

        public Motorista motorista { get; set; }
    }
}
