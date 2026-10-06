using Microsoft.Extensions.DependencyInjection;

namespace MauiApp1;

public partial class App : Application
{
    private readonly ShoppingCardSeeder _shoppingCardSeeder;

    public App(ShoppingCardSeeder shoppingCardSeeder)
    {
        _shoppingCardSeeder = shoppingCardSeeder;
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        _shoppingCardSeeder.Seed();
        return new Window(new AppShell());
    }
}