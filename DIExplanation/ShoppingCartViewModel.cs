namespace DIExplanation;

public class ShoppingCartViewModel
{
    private readonly IShoppingCart _shoppingCart;
    
    public ShoppingCartViewModel(IDiscountCalculator discountCalculator, IShoppingCart shoppingCart)
    {
        _shoppingCart = shoppingCart;
    }
    
    public decimal TotalPrice => _shoppingCart.TotalPrice();
    
    public void AddOrderLine(OrderLine orderLine)
    {
        // Do some checks
        
        _shoppingCart.AddOrderLine(orderLine);
    }
}