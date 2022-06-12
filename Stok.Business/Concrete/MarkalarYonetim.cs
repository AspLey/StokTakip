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
    public class MarkalarYonetim : IListGuncel<Markalar>, ISil<Markalar>
    {
        public Markalar Add(Markalar added)
        {
            using (StokDbContext context = new StokDbContext())
            {
                var ekle = context.Markalars.Add(added);
                context.SaveChanges();
                return ekle;
            }
        }

        public void Delete(Markalar D)
        {
            using (StokDbContext context = new StokDbContext())
            {

                context.Entry(D).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

       

        public List<Markalar> Listele()
        {
            using (StokDbContext context = new StokDbContext())
            {
                var listele = context.Markalars.ToList();
                context.SaveChanges();
                return listele;
            }
        }

        public List<Markalar> Search(string d)
        {
            using (StokDbContext context = new StokDbContext())
            {
                return context.Markalars.Where(x => x.Marka.Contains(d)).ToList();
            }
        }

        public void Update(Markalar U)
        {
            using (StokDbContext context = new StokDbContext())
            {
                context.Entry(U).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
