namespace WebApp.Test;

public class SaleUnitTest1
{
    [Fact]
    public void Discount20()
    {
        Sale sale = new Sale();
        int result = sale.GetPriceDiscount(100, 20);


        Assert.Equal(80, result);
    }

    [Fact]
    public void Discount80()
    {
        Sale sale = new Sale();
        int result = sale.GetPriceDiscount(100, 80);


        Assert.Equal(20, result);
    }

    [Fact]
    public void Discount30()
    {
        Sale sale = new Sale();
        int result = sale.GetPriceDiscount(100, 30);


        Assert.Equal(70, result);
    }
}
