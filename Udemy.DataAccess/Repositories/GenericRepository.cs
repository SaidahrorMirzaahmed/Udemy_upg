using Microsoft.EntityFrameworkCore;
using Udemy.DataAccess.Context;

namespace Udemy.DataAccess.Repositories;
public class GenericRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public async ValueTask<TEntity> InsertAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async ValueTask<TEntity> UpdateAsync(TEntity entity)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return entity;
    }

    public async ValueTask<TEntity> DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async ValueTask<TEntity> SelectAsync(long id)
    {
        return await _dbSet.FindAsync(id);
    }

    public IEnumerable<TEntity> SelectAllAsEnumerable()
    {
        return _dbSet.AsEnumerable();
    }

    public IQueryable<TEntity> SelectAllAsQueryable()
    {
        return _dbSet.AsQueryable();
    }

    public async ValueTask SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
