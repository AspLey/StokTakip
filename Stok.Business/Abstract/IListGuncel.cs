using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Business.Abstract
{
   public interface IListGuncel<stk>:IEkleAra<stk>
    {
        List<stk> Listele();
        void Update(stk U);
        

    }
}
