using DIExplanation;

namespace MauiApp1;

public class ShoppingCardSeeder
{
    private readonly IShoppingCart _shoppingCart;

    public ShoppingCardSeeder(IShoppingCart shoppingCart)
    {
        _shoppingCart = shoppingCart;
    }
    
    public void Seed()
    {
        _shoppingCart.AddOrderLine(new OrderLine { Product = "Product 1", Price = 10m , Quantity = new Random().Next(1, 10) });
        _shoppingCart.AddOrderLine(new OrderLine { Product = "Product 2", Price = 20m , Quantity = new Random().Next(1, 10) });
    }
}