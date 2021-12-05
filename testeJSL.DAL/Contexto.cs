using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using testeJSL.BLL.Models;
using testeJSL.DAL.Mapeamento;

namespace testeJSL.DAL
{
    public class Contexto : IdentityDbContext<Motorista, Funcao, string>
    {

        public DbSet<Motorista> motorista { get; set; }
        public DbSet<Veiculo> veiculo { get; set; }
        public DbSet<Endereco> endereco { get; set; }


        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new MotoristaMap());
            builder.ApplyConfiguration(new VeiculoMap());
            builder.ApplyConfiguration(new EnderecoMap());
        }

    }
}
