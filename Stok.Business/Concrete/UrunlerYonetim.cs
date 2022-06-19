using Stok.Business.Abstract;
using Stok.DataAccess.Concrete;
using Stok.Entities.Concrete.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Business.Concrete
{
    public class UrunlerYonetim : IListGuncel<Urunler>, ISil<Urunler>
    {
        public Urunler Add(Urunler added)
        {
            using (StokDbContext context = new StokDbContext())
            {
                var ekle = context.Urunlers.Add(added);
                context.SaveChanges();
                return ekle;
            }
        }

        public void Delete(Urunler D)
        {
            using (StokDbContext context = new StokDbContext())
            {

                context.Entry(D).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public List<Urunler> Listele()
        {
            using (StokDbContext context = new StokDbContext())
            {
                var listele = context.Urunlers.ToList();
                return listele;
            }
        }

        public List<Urunler> Search(string d)
        {
            using (StokDbContext context = new StokDbContext())
            {
                return context.Urunlers.Where(x => x.UrunAdi.Contains(d)).ToList();
            }
        }

        public void Update(Urunler U)
        {
            using (StokDbContext context = new StokDbContext())
            {
                context.Entry(U).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
