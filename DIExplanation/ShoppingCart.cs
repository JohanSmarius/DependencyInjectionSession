namespace DIExplanation;

public class ShoppingCart
{
    private List<OrderLine> orderLines = [];

    public void AddOrderLine(OrderLine orderLine)
    {
        orderLines.Add(orderLine);
    }

    public decimal TotalPrice()
    {
        var total = orderLines.Sum(x => x.LinePrice);
        
        var discountedTotal = new DiscountCalculator().CalculateDiscount(total);

        return discountedTotal;
    }
}