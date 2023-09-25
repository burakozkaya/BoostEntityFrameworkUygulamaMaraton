using System.Linq.Expressions;
using BoostEntityFrameworkUygulamaMaraton.DAL.Abstract;
using BoostEntityFrameworkUygulamaMaraton.DAL.Context;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;

public abstract class BaseRepo<T> : IRepo<T> where T : class,IEntity
{
    protected DbContext _dbContext;
    protected DbSet<T> _dbSet;

    public BaseRepo(AlbümDbContext context)
    {
        _dbContext = context;
        _dbSet = _dbContext.Set<T>();
    }
    public virtual void Add(T entity)
    {
        _dbSet.Add(entity);
        Save();
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
        Save();
    }

    public T? Get(int id)
    {
        return _dbSet.SingleOrDefault(x=>x.Id == id);
    }

    public List<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public List<T> Find(Expression<Func<T, bool>> predicate)
    {
        return _dbSet.Where(predicate).ToList();
    }

    public void Update(T entity)
    {
        Save();
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }
}