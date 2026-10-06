namespace DIExplanation;

public class ShoppingCart : IShoppingCart
{
    private readonly IDiscountCalculator _discountCalculator;
    private List<OrderLine> orderLines = [];

    public ShoppingCart(IDiscountCalculator discountCalculator)
    {
        _discountCalculator = discountCalculator;
    }

    public void AddOrderLine(OrderLine orderLine)
    {
        orderLines.Add(orderLine);
    }

    public decimal TotalPrice()
    {
        var total = orderLines.Sum(x => x.LinePrice);
        
        var discountedTotal = _discountCalculator.CalculateDiscount(total);

        return discountedTotal;
    }
}