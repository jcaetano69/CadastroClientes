using CadastroDomain.Entities;
using System.Linq.Expressions;

namespace Cadastro.Domain.Interfaces.Query;
public interface IQuery<TQuery, TViewModel>
    where TViewModel : AuditableEntity
    where TQuery : class
{
    Task<TViewModel> BuscarPorId(Guid id);
    Task<TViewModel> Buscar(TQuery query);
    Task<IQueryable<TViewModel>> Listar(Expression<Func<TViewModel, bool>> expression);
    Task<IQueryable<TViewModel>> Listar(TQuery query);
}
