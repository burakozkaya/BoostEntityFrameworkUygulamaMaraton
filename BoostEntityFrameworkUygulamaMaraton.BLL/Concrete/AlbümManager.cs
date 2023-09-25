using BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;

namespace BoostEntityFrameworkUygulamaMaraton.BLL.Concrete;

public class AlbümManager : BaseManager<Albüm>
{
    public AlbümManager(BaseRepo<Albüm> baseRepo) : base(baseRepo)
    {
    }

}