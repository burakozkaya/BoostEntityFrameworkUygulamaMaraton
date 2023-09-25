using System.Security.Cryptography;
using BoostEntityFrameworkUygulamaMaraton.BLL.Concrete;
using BoostEntityFrameworkUygulamaMaraton.DAL.Concrete;
using BoostEntityFrameworkUygulamaMaraton.DAL.Context;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Common;
using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;
using System.Text;

namespace BoostEntityFrameworkUygulamaMaraton.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YoneticiManager yoneticiManager = new YoneticiManager(new YoneticiRepo(new AlbümDbContext()));
            yoneticiManager.AddManager(new Yonetici()
            {
                YoneticiKullaniciAdi = "Burak",
                YoneticiSifre = "123",
            }); 
            yoneticiManager.AddManager(new Yonetici()
            {
                YoneticiKullaniciAdi = "Burak",
                YoneticiSifre = "123",
            });
        }
    }
}