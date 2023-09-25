using BoostEntityFrameworkUygulamaMaraton.ENTITIES.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BoostEntityFrameworkUygulamaMaraton.DAL.Context;

public class AlbümDbContext : DbContext
{
    public DbSet<Albüm> Albümler { get; set; }
    public DbSet<Yonetici> Yoneticiler { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=BURAKS_PC\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Database=AlbümDb");
    }
}