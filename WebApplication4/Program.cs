var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Custom/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Varsay�lan controller'� Custom ve action olarak Homepage olarak ayarl�yoruz
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Custom}/{action=Homepage}/{id?}"); // Burada Custom controller'�n�n Homepage action'�n� varsay�lan olarak kullan�yoruz

app.Run();
