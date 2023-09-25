using BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;

namespace BoostEntityFrameworkUygulamaMaraton.BLL.Concrete;

public class YoneticiManager : BaseManager<Yonetici>
{
    public YoneticiManager(BaseRepo<Yonetici> baseRepo) : base(baseRepo)
    {
    }
}