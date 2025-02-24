using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
    b => b.MigrationsAssembly("StoreApp"));
});


builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".StoreApp.Session";
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


 
builder.Services.AddScoped<IRepositoryManager, RepositoryManger>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IOrderService, OrderManager>();

builder.Services.AddScoped<Cart>(c => SessionCart.GetCart(c)); //IOC

builder.Services.AddAutoMapper(typeof(Program));
var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseRouting();
app.UseSession();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.MapRazorPages();
app.Run();
//  app.MapAreaControllerRoute(
//         name: "Admin",
//         areaName: "Admin",
//         pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
//  );
//     app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
//     app.Run();
// app.MapAreaControllerRoute(
//     name: "Admin",
//     areaName: "Admin",
//     pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
// );
// app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
// app.Run();