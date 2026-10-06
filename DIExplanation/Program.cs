// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DIExplanation;
using WebApi;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IShoppingCart, ShoppingCart>();
builder.Services.AddTransient<IDiscountCalculator, DiscountCalculator>();
builder.Services.AddTransient<ShoppingCartViewModel>();

Console.WriteLine("Hello, World!");

// Just for the demo
var serviceProvider = builder.Services.BuildServiceProvider();
var shoppingCart = serviceProvider.GetRequiredService<ShoppingCartViewModel>();

shoppingCart.AddOrderLine(new OrderLine { Product = "Product 1", Price = 10m , Quantity = 2 });
shoppingCart.AddOrderLine(new OrderLine { Product = "Product 2", Price = 20m , Quantity = 3 });

Console.WriteLine(shoppingCart.TotalPrice);


