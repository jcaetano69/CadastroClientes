using Microsoft.EntityFrameworkCore;
using CadastroDomain.Entities;

namespace Cadastro.Infra.Data.Context;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
}
