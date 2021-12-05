using System;
using System.Collections.Generic;
using System.Text;
using testeJSL.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace testeJSL.DAL.Mapeamento
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.id_Endereco);
            builder.Property(e => e.nomeEndereco).IsRequired();
            builder.Property(e => e.bairro).IsRequired();
            builder.Property(e => e.cidade).IsRequired();
            builder.Property(e => e.cep).IsRequired();
            builder.Property(e => e.numero).IsRequired();
            builder.Property(e => e.complemento);

            builder.Property(v => v.id_Motorista).IsRequired();
            builder.HasOne(v => v.motorista).WithMany(v => v.Endereco).HasForeignKey(v => v.id_Motorista);

            builder.ToTable("Endereco");
        }
    }
}
