using DIExplanation;

namespace WebApi;

public class SpecialDiscountCalculator : IDiscountCalculator
{
    public decimal CalculateDiscount(decimal totalPrice)
    {
        // Apply a special season discount of 50%
        return totalPrice * 0.5m; 
    }
}