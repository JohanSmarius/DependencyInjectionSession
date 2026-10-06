namespace DIExplanation;

public interface IShoppingCart
{
    void AddOrderLine(OrderLine orderLine);
    decimal TotalPrice();
}