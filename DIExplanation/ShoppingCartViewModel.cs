namespace DIExplanation;

public class ShoppingCartViewModel
{
    private readonly ShoppingCart _shoppingCart = new(new DiscountCalculator());
    
    public decimal TotalPrice => _shoppingCart.TotalPrice();
    
    public void AddOrderLine(OrderLine orderLine)
    {
        // Do some checks
        
        _shoppingCart.AddOrderLine(orderLine);
    }
}