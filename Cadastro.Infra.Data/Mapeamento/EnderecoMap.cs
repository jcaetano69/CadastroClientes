using CadastroDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infra.Data.Mapeamento;
internal class EnderecoMap : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.ToTable("enderecos");

        builder.Property<string>(x => x.Rua).HasMaxLength(100);
        builder.Property<int>(x => x.Número).HasMaxLength(20);
        builder.Property<int>(x => x.Cep).HasMaxLength(20);
        builder.Property<string>(x => x.Estado).HasMaxLength(255);
        builder.Property<string>(x => x.Cidade).HasMaxLength(255);
    }
}
