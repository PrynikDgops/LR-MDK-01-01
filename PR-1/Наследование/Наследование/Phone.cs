using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    internal class Phone : Product
    {
        public int ColculateDiscount()
        {
            
            if (saledItem_ >= 20 && saledItem_ < 150)
            {
                return 10;
            }
            if (saledItem_ >= 150 && saledItem_ < 300)
            {
                return 30;
            }
            if (saledItem_ >= 300)
            {
                return 50;
            }
            else
            {
                return defaultDiscount;
            }
        }
    }
}
