namespace DIExplanation;

public interface IShoppingCart
{
    void AddOrderLine(OrderLine orderLine);
    
    IEnumerable<OrderLine> GetAll();
    
    decimal TotalPrice();
}