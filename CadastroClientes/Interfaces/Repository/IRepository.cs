using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Interfaces.Repository;
public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity> Adicionar(TEntity entity);
    Task<TEntity> Atualizar(TEntity entity);
    Task Remover(TEntity Id);
}
