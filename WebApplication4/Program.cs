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

// Varsayýlan controller'ý Custom ve action olarak Homepage olarak ayarlýyoruz
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Custom}/{action=Homepage}/{id?}"); // Burada Custom controller'ýnýn Homepage action'ýný varsayýlan olarak kullanýyoruz

app.Run();
