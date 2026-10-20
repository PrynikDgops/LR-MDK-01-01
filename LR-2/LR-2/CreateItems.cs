using System;

public class CreateItems
{
	public CreateItems()
	{
        struct Item
        {
        public string Name;
        public int Price;
        public int Stock;
        public string Unit;
        public int Ordered;
        }
    }

    static Item[] CreateItems()
    {
    string[] names = { "роза", "тюльпан", "хризантема", "орхидея", "гипсофила" };
    int[] prices = { 180, 120, 350, 1200, 90 };
    int[] stock = { 24, 30, 14, 6, 40 };
    string[] units = { "шт.", "шт.", "шт.", "шт.", "шт." };

    Item[] items = new Item[names.Length];
    for (int i = 0; i < items.Length; i++)
    {
        items[i].Name = names[i];
        items[i].Price = prices[i];
        items[i].Stock = stock[i];
        items[i].Unit = units[i];
        items[i].Ordered = 0;
    }
    return items;
    }
}
