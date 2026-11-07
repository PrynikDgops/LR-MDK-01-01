using System;
using System.Collections.Generic;
using System.Dynamic;
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
            products.Add(laptop0);
            products.Add(laptop1);
            products.Add(laptop2);

            foreach (Product product in products)
            {
                Console.Write($"Название: {product.GetName()}, ");
                Console.Write($"цена: {product.GetPrice()}, ");
                Console.Write($"продано: { product.GetSaledItem()}, ");

                double amount = product.GetPrice() * product.GetSaledItem();
                int discount = product.ColculateDiscount();
                double amountWithDiscount = amount - (amount / 100 * discount);

                Console.Write($"cумма: {amount}, ");
                Console.Write($"скидка: {discount}%, ");
                Console.WriteLine($"сумма с учетом скидки: {amountWithDiscount}");

            }
        }
    }
}
