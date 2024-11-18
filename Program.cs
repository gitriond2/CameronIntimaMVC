using IndumentariaIntima.Data;
using IndumentariaIntima.Services;
using Microsoft.EntityFrameworkCore;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<CarritoService>();

// Agregar servicio de caching
builder.Services.AddResponseCaching();

// Configurar Stripe
StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe")["SecretKey"];

// Configurar EF Core con SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configurar la tubería HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Usar caching de respuestas
app.UseResponseCaching();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



