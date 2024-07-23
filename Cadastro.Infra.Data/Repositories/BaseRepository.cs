using Cadastro.Domain.Interfaces.Repository;
using Cadastro.Infra.Data.Context;
using CadastroDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Infra.Data.Repositories;
public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : AuditableEntity
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;
    private bool isDisposed;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }
    ~BaseRepository()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (isDisposed) return;
        if (disposing)
            _context.Dispose();

        isDisposed = true;
    }
    public async Task<TEntity> Adicionar(TEntity entity)
    {
        entity.created = DateTime.Now;
        entity.rowVersion += 1;
        _dbSet.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public async Task<TEntity> Atualizar(TEntity entity)
    {
        entity.lastModified = DateTime.Now;
        entity.rowVersion += 1;
        _dbSet.Entry(entity).CurrentValues.SetValues(entity);
        _dbSet.Entry(entity).State = EntityState.Modified;
        _dbSet.Update(entity);
        _context.SaveChanges();

        var entry = _context.Entry<TEntity>(entity);

        _dbSet.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    public async Task Remover(TEntity entity)
    {
        TEntity entidade = _dbSet.Find(entity.id);
        _context.Remove(entidade);
        await _context.SaveChangesAsync();
    }
}
