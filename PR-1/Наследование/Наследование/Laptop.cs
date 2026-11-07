using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    internal class Laptop : Product
    {
        public override int ColculateDiscount()
        {

            if (saledItem_ >= 5 && saledItem_ <= 10)
            {
                return 15;
            }
            if (saledItem_ > 10)
            {
                return 25;
            }
            else
            {
                return base.ColculateDiscount();
            }
        }
    }
}
