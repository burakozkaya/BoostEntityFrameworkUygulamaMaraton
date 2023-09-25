using BoostEntityFrameworkUygulamaMaraton.DAL.Context;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;

namespace BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;

public class YoneticiRepo : BaseRepo<Yonetici>
{
    public YoneticiRepo(AlbümDbContext context) : base(context)
    {
    }
}