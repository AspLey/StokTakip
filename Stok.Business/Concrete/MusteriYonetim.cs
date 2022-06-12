using Stok.Business.Abstract;
using Stok.DataAccess.Concrete;
using Stok.Entities.Concrete.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Business.Concrete
{
    public class MusteriYonetim : IListGuncel<Musteri>, ISil<Musteri>
    {
        public Musteri Add(Musteri added)
        {
            using(StokDbContext context=new StokDbContext())
            {
                var ekle = context.Musteris.Add(added);
                context.SaveChanges();
                return ekle;

            }
        }

        public void Delete(Musteri D)
        {
            using (StokDbContext context = new StokDbContext())
            {

                context.Entry(D).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

        

        public List<Musteri> Listele()
        {
            using (StokDbContext context = new StokDbContext())
            {
                var listele = context.Musteris.ToList();
                context.SaveChanges();
                return listele;
            }
        }

        public List<Musteri> Search(string d)
        {
            using (StokDbContext context = new StokDbContext())
            {
                return context.Musteris.Where(x => x.AdSoyad.Contains(d)).ToList();
            }
        }

        public void Update(Musteri U)
        {
            using (StokDbContext context = new StokDbContext())
            {
                context.Entry(U).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
