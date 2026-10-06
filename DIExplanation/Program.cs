// See https://aka.ms/new-console-template for more information

using DIExplanation;

Console.WriteLine("Hello, World!");

var shoppingCart = new ShoppingCartViewModel(new DiscountCalculator(new UserRepository()));

shoppingCart.AddOrderLine(new OrderLine { Product = "Product 1", Price = 10m , Quantity = 2 });
shoppingCart.AddOrderLine(new OrderLine { Product = "Product 2", Price = 20m , Quantity = 3 });

Console.WriteLine(shoppingCart.TotalPrice);


