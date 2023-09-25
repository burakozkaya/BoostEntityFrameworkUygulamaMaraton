using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Abstract;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Common;

namespace BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;

public class Albüm : IEntity
{
    public int Id { get; set; }
    public string AlbümAdı { get; set; }
    public string AlbümSanatciGrup { get; set; }
    public DateTime AlbümCikisTarihi { get; set; }
    public decimal AlbümFiyati { get; set; }
    public int AlbümIndirimOrani { get; set; }
    public SatisDurumu AlbümSatisDevamliligi { get; set; }

}