using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace testeJSL.BLL.Models
{
    public class Funcao : IdentityRole<string>
    {
        public string descricao { get; set; }
    }
}
