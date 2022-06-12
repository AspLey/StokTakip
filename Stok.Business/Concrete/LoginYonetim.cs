using Stok.Business.Abstract;
using Stok.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Business.Concrete
{
    public class LoginYonetim : ILogin
    {
        StokDbContext stokDb = new StokDbContext();

        
       private bool userName = false;
       private bool password = false;
      



        public bool Login(string UserName, string Password)
        {
            foreach (var user in stokDb.Personels.Select(X => X.KullaniciAdi).ToList())
            {
                if (UserName == user)
                {
                    userName = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            foreach (var sifre in stokDb.Personels.Select(X => X.sifre).ToList())
            {
                if (Password == sifre)
                {
                    password = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (userName == true && password == true)
                return true;
            return false;
        }
    }

}

