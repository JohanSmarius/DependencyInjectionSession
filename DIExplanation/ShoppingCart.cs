namespace DIExplanation;

public class ShoppingCart
{
    private List<OrderLine> orderLines = [];

    public void AddOrderLine(OrderLine orderLine)
    {
        orderLines.Add(orderLine);
    }

    public decimal TotalPrice(IDiscountCalculator discountCalculator)
    {
        var total = orderLines.Sum(x => x.LinePrice);
        
        var discountedTotal = discountCalculator.CalculateDiscount(total);

        return discountedTotal;
    }
}