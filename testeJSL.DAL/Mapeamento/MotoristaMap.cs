using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using testeJSL.BLL.Models;

namespace testeJSL.DAL.Mapeamento
{
    public class MotoristaMap : IEntityTypeConfiguration<Motorista>
    {
        public void Configure(EntityTypeBuilder<Motorista> builder)
        {
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.primeiroNome).IsRequired();
            builder.Property(m => m.segundoNome).IsRequired();

            builder.HasMany(m => m.Veiculos).WithOne(m => m.motorista);
            builder.HasMany(m => m.Endereco).WithOne(m => m.motorista);

            builder.ToTable("Motorista");

        }
    }
}
