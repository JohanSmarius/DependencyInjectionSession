namespace DIExplanation;

public class DiscountCalculator : IDiscountCalculator
{
    private readonly IUserRepository _userRepository;

    public DiscountCalculator(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public decimal CalculateDiscount(decimal totalPrice)
    {
        return totalPrice * 0.9m * _userRepository.GetUser(1).NumberOfTimesOrdered;
        return totalPrice * 0.9m * _userRepository.GetUser(1).NumberOfTimesOrdered;
    }
}