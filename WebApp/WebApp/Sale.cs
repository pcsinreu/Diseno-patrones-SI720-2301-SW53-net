using System;
namespace WebApp
{
	public class Sale
	{
		public Sale()
		{
		}

		public int GetPriceDiscount(int originalPrice, int discount)
		{
			return originalPrice - originalPrice * discount / 100 ;
		}

        public string greet(string name)
        {
			return "Hello," + name;
        }

        public int getMax(int value1, int value2 ,int value3)
        {
            return value1;
        }
    }
}

