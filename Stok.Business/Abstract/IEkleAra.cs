using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Business.Abstract
{
   public interface IEkleAra<Stk>
    {
        Stk Add(Stk added);
        List<Stk> Search(string d);


    }
}
