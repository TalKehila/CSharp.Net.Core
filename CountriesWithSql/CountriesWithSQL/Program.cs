using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CountriesWithSQL.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CountriesWithSQLContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CountriesWithSQLContext") ?? throw new InvalidOperationException("Connection string 'CountriesWithSQLContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Countries}/{action=Index}/{id?}");

app.Run();
