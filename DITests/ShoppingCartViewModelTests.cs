using DIExplanation;
using Moq;

namespace DITests;

public class ShoppingCartViewModelTests
{
    [Fact]
    public void TotalPrice_Should_Return_Price_From_ShoppingCart()
    {
        // Arrange
        var shoppingCart = new Mock<IShoppingCart>();
        shoppingCart.Setup(x => x.TotalPrice()).Returns(100);
        var shoppingCartViewModel = new ShoppingCartViewModel(shoppingCart.Object);

        var returnedResult = shoppingCartViewModel.TotalPrice;;
        
        Assert.Equal(100, returnedResult);
        
    }
}