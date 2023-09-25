using BoostEntityFrameworkUygulamaMaraton.BLL.ViewModel;
using BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;
using System.Collections.Generic;

namespace BoostEntityFrameworkUygulamaMaraton.BLL.Concrete;

public class AlbümManager : BaseManager<Albüm>
{
    private AlbümRepo _albümRepo;
    public List<AlbümVM> AlbümVmList;
    public AlbümManager(BaseRepo<Albüm> baseRepo) : base(baseRepo)
    {
        _albümRepo = (AlbümRepo)_baseRepo;
    }
    public List<AlbümVM> SatisDurmusAlbümlerManager()
    {
        AlbümVmList = new List<AlbümVM>();
        _albümRepo.SatisDurmusAlbümler().ForEach(x => AlbümVmList.Add(new AlbümVM()
        {
            AlbümAdı = x.AlbümAdı,
            AlbümSanatciGrupAdi = x.AlbümSanatciGrup
        }));
        return AlbümVmList;
    }

    public List<AlbümVM> SatisaDevamEdenAlbümlerManager()
    {

        AlbümVmList = new List<AlbümVM>();
        _albümRepo.SatisaDevamEdenAlbümler().ForEach(x=>AlbümVmList.Add(new AlbümVM()
        {
            AlbümAdı = x.AlbümAdı,
            AlbümSanatciGrupAdi = x.AlbümSanatciGrup
        }));
        return AlbümVmList;
    }

    public List<AlbümVM> SonEklenenAlbümlerManager()
    {
        AlbümVmList = new List<AlbümVM>();
        _albümRepo.SonEklenenAlbümler().ForEach(x => AlbümVmList.Add(new AlbümVM()
        {
            AlbümAdı = x.AlbümAdı,
            AlbümSanatciGrupAdi = x.AlbümSanatciGrup
        }));
        return AlbümVmList;
    }

    public List<AlbümVM> IndirimdekiAlbümlerManager()
    {
        AlbümVmList = new List<AlbümVM>();
        _albümRepo.IndirimdekiAlbümler().ForEach(x => AlbümVmList.Add(new AlbümVM()
        {
            AlbümAdı = x.AlbümAdı,
            AlbümSanatciGrupAdi = x.AlbümSanatciGrup
        }));
        return AlbümVmList;
    }
}