using System;

public class Creates
{
	public Creates()
	{
        static string[] CreateNames()
        {
            return new string[] { "роза", "тюльпан", "хризантема", "орхидея", "гипсофила" };
        }

        static int[] CreatePrices()
        {
            return new int[] { 180, 120, 350, 1200, 90 };
        }

        static int[] CreateStock()
        {
            return new int[] { 24, 30, 14, 6, 40 };
        }

        static string[] CreateUnits()
        {
            return new string[] { "шт.", "шт.", "шт.", "шт.", "шт." };
        }
    }
}
