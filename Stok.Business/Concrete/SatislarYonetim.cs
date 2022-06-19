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
    public class SatislarYonetim : IListGuncel<Satislar>, ISil<Satislar>
    {
        public Satislar Add(Satislar added)
        {
            using (StokDbContext context = new StokDbContext())
            {
                var ekle = context.Satislars.Add(added);
                context.SaveChanges();
                return ekle;

            }
        }

        public void Delete(Satislar D)
        {
            using (StokDbContext context = new StokDbContext())
            {

                context.Entry(D).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

        

        public List<Satislar> Listele()
        {
            using (StokDbContext context = new StokDbContext())
            {
                var listele = context.Satislars.ToList();
                return listele;
            }
        }

        public List<Satislar> Search(string d)
        {
            throw new NotImplementedException();
        }

        public void Update(Satislar U)
        {
            throw new NotImplementedException();
        }
    }
}
