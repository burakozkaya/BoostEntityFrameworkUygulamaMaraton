using BoostEntityFrameworkUygulamaMaraton.DAL.Context;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;

namespace BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;

public class AlbümRepo : BaseRepo<Albüm>
{
    public AlbümRepo(AlbümDbContext context) : base(context)
    {
        
    }

    public List<Albüm> SatisDurmusAlbümlerListele()
    {
        _dbSet.Select(a => new {
                a.AlbumAdi
                a.AlbumSanatciGrup
            }).ToList();
        }
    //var cozum1 = DbSet.Select(a => new {
    //    a.AlbumAdi
    //    a.AlbumSanatciGrup
    //}).ToList();


        //var cozum2 = DbSet.Where(a => a.SatisDurumu = Enum.Satista).Select(a => new {
        //    a.AlbumAdi
        //    a.AlbumSanatciGrup
        //});

        //var cozum3_1 = DbSet.Select(a => new {
        //    a.AlbumAdi
        //    a.AlbumSanatciGrup
        //}).ToList();

        //Var cozum3_2 = Enumerable.Reverse(cozum3_1).Take(10).Reverse().ToList();

        //var cozum4 = DbSet.Where(a => a.Indirim != null).OrderByDescending(a => a.IndirimOrani).Select(a => new {
        //    a.AlbumAdi
        //    a.AlbumSanatciGrup
        //}).ToList();
}