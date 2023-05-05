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


		//Function to get final price
		//var1 original price
		//var2 Discount in %
		//var3 flag to validate if the product has discount
		//var4 flag to validate if the product is affected to taxes
		public double Function1(double var1, double var2, bool var3, bool var4)
		{

            //extract the discount
            double var6 = 0;
            if (var3 == true)
			{
                double var5 = var1 * var2 / 100;
                var6 = var1 - var5;
            }
			else
			{
				var6 = var1 - 0;

            }


            //Add taxes
            double var7 = 0;
            if (var4 == true) // validate if the product is affected
			{
                var1 = var7 + var7 *0.18;//adding taxes IGV
            }
			else
			{
				var1 = var7 + 0; // no tax added

            }

			return var7;
		}







    }
}

