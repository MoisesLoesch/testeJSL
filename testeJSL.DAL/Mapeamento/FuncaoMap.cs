using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using testeJSL.BLL.Models;

namespace testeJSL.DAL.Mapeamento
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.descricao).IsRequired();

            builder.HasData(
                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Motorista",
                    NormalizedName = "MOTORISTA",
                    descricao = "Caminhoneiro"
                });

            builder.ToTable("Funcoes");

        }
    }
}
