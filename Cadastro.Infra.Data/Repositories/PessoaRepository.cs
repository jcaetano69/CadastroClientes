using Cadastro.Domain.Interfaces.Repository;
using Cadastro.Infra.Data.Context;
using CadastroDomain.Entities;

namespace Cadastro.Infra.Data.Repositories;
public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
{
    public PessoaRepository(AppDbContext context) : base(context)
    {
    }
}
