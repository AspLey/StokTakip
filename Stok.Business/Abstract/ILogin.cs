using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Business.Abstract
{
   public interface ILogin
    {

         bool  Login(string UserName, string Password);
    }
}
