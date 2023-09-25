using System.Collections;
using BoostEntityFrameworkUygulamaMaraton.DAL.Context;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Common;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;

namespace BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;

public class AlbümRepo : BaseRepo<Albüm>
{
    public AlbümRepo(AlbümDbContext context) : base(context)
    {
        
    }

    public List<Albüm> SatisDurmusAlbümler()
    {
        return _dbSet
            .Where(x => x.AlbümSatisDevamliligi == SatisDurumu.Iptal).
            Select(a => new Albüm
        {
            AlbümAdı = a.AlbümAdı,
            AlbümSanatciGrup = a.AlbümSanatciGrup
        })
            .ToList();
    }

    public List<Albüm> SatisaDevamEdenAlbümler()
    {
        return _dbSet
            .Where(x => x.AlbümSatisDevamliligi == SatisDurumu.Satista)
            .Select(a => new Albüm
            {
                AlbümAdı = a.AlbümAdı,
                AlbümSanatciGrup = a.AlbümSanatciGrup
            })
            .ToList();
    }

    public List<Albüm> SonEklenenAlbümler()
    {
        return _dbSet.OrderByDescending(x=>x.Id).Take(10).Select(a => new Albüm
        {
            AlbümAdı = a.AlbümAdı,
            AlbümSanatciGrup = a.AlbümSanatciGrup
        }).ToList();
    }

    public List<Albüm> IndirimdekiAlbümler()
    {
        return _dbSet
            .Where(x => x.AlbümIndirimOrani != 0)
            .OrderByDescending(x => x.AlbümIndirimOrani)
            .Select(a =>
            new Albüm
            {
                AlbümAdı = a.AlbümAdı,
                AlbümSanatciGrup = a.AlbümSanatciGrup
            })
            .ToList();
    }
}