using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    public class Product
    {
        protected string name_;
        protected double price_;
        protected int saledItem_;
        

        public virtual int ColculateDiscount()
        {
            return 0;
        }

        public void Set(string name, double price, int saledItem)
        {
            name_ = name;
            price_ = price;
            saledItem_ = saledItem;
        }
        public string GetName()
        {
            return name_;
        }
        public double GetPrice()
        {
            return price_;
        }
        public int GetSaledItem()
        {
            return saledItem_;
        }
    }
}
