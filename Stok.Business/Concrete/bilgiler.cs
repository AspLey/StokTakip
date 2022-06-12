using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Business.Concrete
{
    public static class bilgiler
    {
        private static string kullaniciad;
        private static string  sifree;
        


        public static string KULLANICIADI
        {
            get { return kullaniciad; }
            set
            {
                kullaniciad = value;
            }
        }
        public static string SIFRE
        {
            get { return sifree; }
            set
            {
                sifree = value;
            }
        }
    }
}
