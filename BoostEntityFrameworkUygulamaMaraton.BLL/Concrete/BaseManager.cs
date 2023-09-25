using System.Linq.Expressions;
using BoostEntityFrameworkUygulamaMaraton.BLL.Abstract;
using BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Abstract;

namespace BoostEntityFrameworkUygulamaMaraton.BLL.Concrete;

public class BaseManager<T> : IManager<T> where T : class,IEntity
{
    protected BaseRepo<T> _baseRepo;

    public BaseManager(BaseRepo<T> baseRepo)
    {
        _baseRepo = baseRepo;
    }
    public void AddManager(T entity)
    {
        _baseRepo.Add(entity);
    }

    public void DeleteManager(T entity)
    {
        _baseRepo.Delete(entity);
    }

    public T? GetManager(int id)
    {
        return _baseRepo.Get(id);
    }

    public List<T> GetAllManager()
    {
        return _baseRepo.GetAll();
    }

    public List<T> FindManager(Expression<Func<T, bool>> predicate)
    {
        return _baseRepo.Find(predicate);
    }

    public void UpdateManager(T entity)
    {
        _baseRepo.Update(entity);
    }
}