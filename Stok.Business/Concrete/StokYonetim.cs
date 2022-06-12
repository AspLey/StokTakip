using Stok.Business.Abstract;
using Stok.DataAccess.Concrete;
using Stok.Entities.Concrete.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Business.Concrete
{
    public class StokYonetim : IListGuncel<Stok.Entities.Concrete.Tables.Stok>, ISil<Stok.Entities.Concrete.Tables.Stok>
    {
    
        
        public Entities.Concrete.Tables.Stok Add(Entities.Concrete.Tables.Stok added)
        {
            using (StokDbContext context = new StokDbContext())
            {
                var ekle = context.Stoks.Add(added);
                context.SaveChanges();
                return ekle;
            }

        }

        public void Delete(Entities.Concrete.Tables.Stok D)
        {
            using (StokDbContext context = new StokDbContext())
            {

                context.Entry(D).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public List<Entities.Concrete.Tables.Stok> Listele()
        {
            using (StokDbContext context = new StokDbContext())
            {
                var listele = context.Stoks.ToList();
                context.SaveChanges();
                return listele;
            }
        }

        public List<Entities.Concrete.Tables.Stok> Search(string d)
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Concrete.Tables.Stok U)
        {
            using (StokDbContext context = new StokDbContext())
            {
                context.Entry(U).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
