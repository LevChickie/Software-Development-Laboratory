using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Otthonbazar.Data.EntityTypeConfigurations;

namespace Otthonbazar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Advertisement> Advertisements{ get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //City tábla létrehozása City néven
            builder.Entity<City>().ToTable("City");
            builder.Entity<Advertisement>().ToTable("Advertisement");
            //Itt lehet kapcsolatokat felállítani -->már az osztályoknál felállítottuk a kapcsolatokat.
            //Attributumok helyett itt lehetnek kötelezettséget parancsolni - kötelező tulajdonságok
            //--> fluent API
            builder.ApplyConfiguration(new CitySeedConfig());
            builder.ApplyConfiguration(new AdvertisementSeedConfig());
            //Példa
            /*builder.Entity<Advertisement>()
                .HasOne(a => a.City)
                .WithMany(c => c.Advertisements)
                .HasForeignKey(a => a.CityId);*/
            //Létre kell hozni egy új migrációt legenerálja a frissített adatbázisból, kell a mitigáció
            //Package Manager Console -> Add-Mitigation "nev"
            //Package Manager Console -> Update-Database --> adatbázis frissítése
        }
    }
}
