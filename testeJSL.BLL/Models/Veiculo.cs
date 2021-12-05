using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testeJSL.BLL.Models
{
    public class Veiculo
    {
        public int id_Veiculo { get; set; }

        public string marca { get; set; }

        public string modelo { get; set; }

        public string placa { get; set; }

        public string eixos { get; set; }

        public string id_Motorista { get; set; }

        public Motorista motorista { get; set; }
    }
}
