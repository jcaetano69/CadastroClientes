using Cadastro.Domain.Interfaces.Repository;
using Cadastro.Infra.Data.Context;
using CadastroDomain.Entities;

namespace Cadastro.Infra.Data.Repositories;
public class PessoaRepository : IPessoaRepository
{
    public AppDbContext  _context;
    public PessoaRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Pessoa> GetPessoas()
    {
        return _context.Pessoas;
    }
}
