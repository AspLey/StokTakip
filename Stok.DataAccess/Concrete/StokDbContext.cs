
using Stok.Entities.Concrete.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.DataAccess.Concrete
{
  public  class StokDbContext:DbContext
    {
        public StokDbContext()
        {
            Database.SetInitializer<StokDbContext>(null);
        }

        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Markalar> Markalars { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Satislar> Satislars { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Yetki> yetkis { get; set; }

        public DbSet<Stok.Entities.Concrete.Tables.Stok> Stoks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategoriler>().ToTable("Kategoriler");
            modelBuilder.Entity<Markalar>().ToTable("Markalar");
            modelBuilder.Entity<Personel>().ToTable("Personel");
            modelBuilder.Entity<Satislar>().ToTable("Satislar");
            modelBuilder.Entity<Urunler>().ToTable("Urunler");
            modelBuilder.Entity<Musteri>().ToTable("Musteri");
            modelBuilder.Entity<Yetki>().ToTable("Yetki");
            modelBuilder.Entity<Stok.Entities.Concrete.Tables.Stok>().ToTable("Stok");
        }
    }
}
