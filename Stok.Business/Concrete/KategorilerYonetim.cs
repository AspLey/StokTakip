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
    public class KategorilerYonetim : IListGuncel<Kategoriler>, ISil<Kategoriler>
    {
        public Kategoriler Add(Kategoriler added)
        {
            using (StokDbContext context = new StokDbContext())
            {
                var ekle = context.Kategorilers.Add(added);
                context.SaveChanges();
                return ekle;
            }
        }

        public void Delete(Kategoriler D)
        {
            using (StokDbContext context = new StokDbContext())
            {

                context.Entry(D).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

       

        public List<Kategoriler> Listele()
        {
            using (StokDbContext context = new StokDbContext())
            {
                var listele = context.Kategorilers.ToList();
                return listele;
            }
        }

        public List<Kategoriler> Search(string d)
        {
            using (StokDbContext context = new StokDbContext())
            {
                return context.Kategorilers.Where(x => x.KategoriAdi.Contains(d)).ToList();
            }


        }

        public void Update(Kategoriler U)
        {
            using (StokDbContext context = new StokDbContext())
            {
                context.Entry(U).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
