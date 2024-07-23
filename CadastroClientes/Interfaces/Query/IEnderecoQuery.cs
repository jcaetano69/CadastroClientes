using Cadastro.Domain.QueriesModel;
using CadastroDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Interfaces.Query;
public interface IEnderecoQuery : IQuery<EnderecoQueryModel, Endereco>
{
}
