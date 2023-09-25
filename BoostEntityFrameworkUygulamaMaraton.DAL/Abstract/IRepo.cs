using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoostEntityFrameworkUygulamaMaraton.DAL.Abstract;

public interface IRepo<T> where T : IEntity
{
    public void Add(T entity);
    public void Delete(T entity);
    public  T? Get(int id);
    public  List<T> GetAll();
    public List<T> Find(Expression<Func<T,bool>> predicate);
    public void Update(T entity);
    public void Save();
}