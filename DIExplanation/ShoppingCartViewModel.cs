namespace DIExplanation;

public class ShoppingCartViewModel
{
    private readonly ShoppingCart _shoppingCart = new();
    
    public void AddOrderLine(OrderLine orderLine)
    {
        // Do some checks
        
        _shoppingCart.AddOrderLine(orderLine);
    }
    
    public decimal TotalPrice => _shoppingCart.TotalPrice(new DiscountCalculator());
}