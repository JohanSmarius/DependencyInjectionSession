using DIExplanation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Mappers;
using WebAPIController.Models;

namespace WebAPIController.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShoppingCartController : ControllerBase
{
    private readonly IShoppingCart _shoppingCart;

    public ShoppingCartController(IShoppingCart shoppingCart)
    {
        _shoppingCart = shoppingCart;
    }

    [HttpGet]
    public ActionResult<List<OrderLineDTO>> GetAll()
    {
        return _shoppingCart.GetAll().ToDTO().ToList();
    }
}