using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Phone phone0 = new Phone();
            phone0.Set("Iphone", 100000, 25);
            Phone phone1 = new Phone();
            phone1.Set("Poco", 25000, 200);
            Phone phone2 = new Phone();
            phone2.Set("Samsung", 40000, 500);
            products.Add(phone0);
            products.Add(phone1);
            products.Add(phone2);
            Laptop laptop0 = new Laptop();
            laptop0.Set("Asus", 45000, 7);
            Laptop laptop1 = new Laptop();
            laptop1.Set("Aser", 50000, 15);
            Laptop laptop2 = new Laptop();
            laptop2.Set("MacBook", 150000, 3);

            
        }
    }
}
