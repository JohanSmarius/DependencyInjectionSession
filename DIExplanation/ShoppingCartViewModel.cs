namespace DIExplanation;

public class ShoppingCartViewModel
{
    private readonly IDiscountCalculator _discountCalculator;
    private readonly ShoppingCart _shoppingCart;
    
    public ShoppingCartViewModel(IDiscountCalculator discountCalculator)
    {
        _discountCalculator = discountCalculator;
        _shoppingCart = new ShoppingCart(discountCalculator);
    }
    
    public decimal TotalPrice => _shoppingCart.TotalPrice();
    
    public void AddOrderLine(OrderLine orderLine)
    {
        // Do some checks
        
        _shoppingCart.AddOrderLine(orderLine);
    }
}