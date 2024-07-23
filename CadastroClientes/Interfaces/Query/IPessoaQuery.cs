using Cadastro.Domain.QueriesModel;
using CadastroDomain.Entities;

namespace Cadastro.Domain.Interfaces.Query;
public interface IPessoaQuery : IQuery<PessoaQueryModel, Pessoa>
{
    Task<IEnumerable<Pessoa>> RecuperarPessoas();
}
