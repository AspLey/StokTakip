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
    public class PersonelYonetim : IListGuncel<Personel>, ISil<Personel>
    {
        StokDbContext context = new StokDbContext();
        public Personel Add(Personel added)
        {
            using (StokDbContext context = new StokDbContext())
            {
                var ekle = context.Personels.Add(added);
                context.SaveChanges();
                return ekle;

            }
        }

        public void Delete(Personel D)
        {
            using (StokDbContext context = new StokDbContext())
            {

                context.Entry(D).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

      

        public List<Personel> Listele()
        {
            using (StokDbContext context = new StokDbContext())
            {
                var listele = context.Personels.ToList();
                context.SaveChanges();
                return listele;
            }
        }

        public List<Personel> Search(string d)
        {
            using (StokDbContext context = new StokDbContext())
            {
                return context.Personels.Where(x => x.AdSoyad.Contains(d)).ToList();
            }
        }

        public void Update(Personel U)
        {
            using (StokDbContext context = new StokDbContext())
            {
                context.Entry(U).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
           
        }
    }
}
