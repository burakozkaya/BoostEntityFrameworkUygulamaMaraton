using BoostEntityFrameworkUygulamaMaraton.BLL.Validation_Rules;
using BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BoostEntityFrameworkUygulamaMaraton.BLL.Concrete;

public class YoneticiManager : BaseManager<Yonetici>
{
    private YoneticiRepo _yoneticiRepo;
    private Vali
    public YoneticiManager(BaseRepo<Yonetici> baseRepo) : base(baseRepo)
    {
        _yoneticiRepo = (YoneticiRepo?)_baseRepo;
    }
    public override void AddManager(Yonetici entity)
    {

        _yoneticiRepo.Add(entity);
    }
}