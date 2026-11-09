using ViewTask.Models;
using Xunit;

namespace ViewTask.Tests;

public class ProductTests
{
    [Fact]
    public void Product_StoresNameAndPrice()
    {
        var product = new Product { Name = "Bread", Price = 10.5 };

        Assert.Equal("Bread", product.Name);
        Assert.Equal(10.5, product.Price);
    }
}
