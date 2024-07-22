using CadastroDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cadastro.Infra.Data.Mapeamento;
internal class PessoaMap : IEntityTypeConfiguration<Pessoa>
{
    public void Configure(EntityTypeBuilder<Pessoa> builder)
    {
        builder.ToTable("pessoas");
        builder.HasKey(x => x.id);

        builder.Property<string>(x => x.Nome).HasMaxLength(255);
        builder.Property<string>(x => x.Email).HasMaxLength(100);
        builder.Property<string>(x => x.Cpf).HasMaxLength(11);
        builder.Property<string>(x => x.Rg).HasMaxLength(100);
        builder.Property<EGenero>(x => x.Genero);
        builder.Property<string>(x => x.Celular).HasMaxLength(100);
        builder.Property<string>(x => x.Observacoes).HasMaxLength(100);
        builder.Property<Endereco>(x => x.Endereco);
        builder.Property<EEstadoCivil>(x => x.EstadoCivil);
    }
}
