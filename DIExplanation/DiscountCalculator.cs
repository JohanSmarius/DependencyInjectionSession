namespace DIExplanation;

public class DiscountCalculator : IDiscountCalculator
{
    public decimal CalculateDiscount(decimal totalPrice)
    {
        return totalPrice * 0.9m;
    }
}