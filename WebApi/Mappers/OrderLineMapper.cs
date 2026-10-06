using DIExplanation;
using WebAPIController.Models;

namespace WebApi.Mappers;

public static class OrderLineMapper
{
    public static OrderLineDTO ToDTO(this OrderLine orderLine)
    {
        ArgumentNullException.ThrowIfNull(orderLine);

        return new OrderLineDTO
        {
            Product = orderLine.Product,
            Quantity = orderLine.Quantity,
            Price = orderLine.Price,
            LinePrice = orderLine.LinePrice
        };
    }

    public static OrderLineDTO ToDto(this OrderLine orderLine) => orderLine.ToDTO();

    public static IEnumerable<OrderLineDTO> ToDTO(this IEnumerable<OrderLine> orderLines)
    {
        ArgumentNullException.ThrowIfNull(orderLines);

        return orderLines.Select(ol => ol.ToDTO());
    }

    public static IEnumerable<OrderLineDTO> ToDto(this IEnumerable<OrderLine> orderLines) => orderLines.ToDTO();
}

