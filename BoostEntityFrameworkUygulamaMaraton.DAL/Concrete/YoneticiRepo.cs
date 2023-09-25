using System.Security.Cryptography.X509Certificates;
using BoostEntityFrameworkUygulamaMaraton.DAL.Context;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;

namespace BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;

public class YoneticiRepo : BaseRepo<Yonetici>
{
    public YoneticiRepo(AlbümDbContext context) : base(context)
    {
    }

    public override void Add(Yonetici entity)
    {
        if(_dbSet.Any(x => x.YoneticiKullaniciAdi == entity.YoneticiKullaniciAdi))
            return;
        base.Add(entity);
    }
}