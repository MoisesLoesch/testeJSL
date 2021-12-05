
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testeJSL.BLL.Models;

namespace testeJSL.DAL.Mapeamento
{
    public class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(v => v.id_Veiculo);
            builder.Property(v => v.marca).IsRequired();
            builder.Property(v => v.modelo).IsRequired();
            builder.Property(v => v.placa).IsRequired().HasMaxLength(8);
            builder.HasIndex(v => v.placa).IsUnique();
            builder.Property(v => v.eixos).IsRequired().HasMaxLength(3);

            builder.Property(v => v.id_Motorista).IsRequired();
            builder.HasOne(v => v.motorista).WithMany(v => v.Veiculos).HasForeignKey(v => v.id_Motorista);

            builder.ToTable("Veiculo");
            
        }
    }
}
