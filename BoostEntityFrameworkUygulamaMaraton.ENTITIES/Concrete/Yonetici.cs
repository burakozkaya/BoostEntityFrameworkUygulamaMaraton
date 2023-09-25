using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Abstract;

namespace BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;

public class Yonetici : IEntity
{
    public int Id { get; set; }
    public string YoneticiKullaniciAdi { get; set; }
    public string YoneticiSifre { get; set; }
}