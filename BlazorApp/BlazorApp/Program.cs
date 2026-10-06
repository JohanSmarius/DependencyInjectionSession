using BlazorApp;
using BlazorApp.Client.Pages;
using BlazorApp.Components;
using DI = DIExplanation;
using DIExplanation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddHttpClient();

builder.Services.AddScoped<ShoppingCardSeeder>();

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IShoppingCart, DI.ShoppingCart>();
builder.Services.AddTransient<IDiscountCalculator, DiscountCalculator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorApp.Client._Imports).Assembly);

app.MapGet("/api/shoppingcart", (IShoppingCart shoppingCart) =>
{
    return shoppingCart.GetAll();
});

using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<ShoppingCardSeeder>().Seed();
}

app.Run();