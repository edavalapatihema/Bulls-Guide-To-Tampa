var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Use custom error handling in production.
    app.UseHsts(); // Enforce strict HTTPS transport security.
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configure routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Sets Home/Index as the default route

app.MapControllerRoute(
    name: "places",
    pattern: "{controller=Places}/{action=BusinessDetails}/{id?}"); // Additional route for Places

app.MapControllerRoute(
    name: "about",
    pattern: "{controller=About}/{action=About}/{id?}");
app.MapControllerRoute(
    name: "business",
    pattern: "{controller=Business}/{action=Business}/{id?}");

app.Run();
