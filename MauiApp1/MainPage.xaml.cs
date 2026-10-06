namespace MauiApp1;

using DIExplanation;

public partial class MainPage : ContentPage
{
    private readonly IShoppingCart? _shoppingCart;
    int count = 0;

    public MainPage() : this(null)
    {
    }

    public MainPage(IShoppingCart? shoppingCart)
    {
        InitializeComponent();
        _shoppingCart = shoppingCart;
        BindingContext = this;
    }

    public IEnumerable<OrderLine> LineItems => _shoppingCart?.GetAll() ?? Enumerable.Empty<OrderLine>();

    
}