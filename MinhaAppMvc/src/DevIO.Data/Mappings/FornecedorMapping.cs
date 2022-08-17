using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(fr => fr.Id);

            builder.Property(fr => fr.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(fr => fr.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");


            /* EF Relations */
            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(fr => fr.Endereco)
                .WithOne(en => en.Fornecedor);

            // 1 : N => Fornecedor : Produto
            builder.HasMany(fr => fr.Produtos)
                .WithOne(pr => pr.Fornecedor)
                .HasForeignKey(pr => pr.FornecedorId);

            builder.ToTable("Fornecedores");
        }
    }
}
