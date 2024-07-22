using CadastroDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Interfaces.Repository;
public interface IPessoaRepository
{
    IEnumerable<Pessoa> GetPessoas();
}
