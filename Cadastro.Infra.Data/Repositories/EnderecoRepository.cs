using Cadastro.Domain.Interfaces.Repository;
using Cadastro.Infra.Data.Context;
using CadastroDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infra.Data.Repositories;
public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
{
    public EnderecoRepository(AppDbContext context) : base(context)
    {
    }
}
