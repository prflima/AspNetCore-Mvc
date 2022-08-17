using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(en => en.Id);

            builder.Property(en => en.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(en => en.Numero)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(en => en.Cep)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(en => en.Complemento)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(en => en.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(en => en.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(en => en.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.ToTable("Enderecos");
        }
    }
}
