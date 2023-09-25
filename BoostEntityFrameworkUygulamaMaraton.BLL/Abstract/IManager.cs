using BoostEntityFrameworkUygulamaMaraton.DAL.Abstract;
using System.Linq.Expressions;

namespace BoostEntityFrameworkUygulamaMaraton.BLL.Abstract;

public interface IManager<T> where T : class
{
    public void AddManager(T entity);
    public void DeleteManager(T entity);
    public T? GetManager(int id);
    public List<T> GetAllManager();
    public List<T> FindManager(Expression<Func<T, bool>> predicate);
    public void UpdateManager(T entity);
}