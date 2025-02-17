using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p=>p.Price).IsRequired();
            builder.HasData(
               new Product { ProductID = 1, ProductName = "Ryzen 5 3600", Price = 200, CategoryId = 1, ImageUrl = "/images/1.jpg" },
            new Product { ProductID = 2, ProductName = "Corsair Vengeance 16GB", Price = 80, CategoryId = 1, ImageUrl = "/images/2.jpg" },
            new Product { ProductID = 3, ProductName = "Samsung 970 EVO Plus 1TB", Price = 120, CategoryId = 1, ImageUrl = "/images/3.jpg" },
            new Product { ProductID = 4, ProductName = "Western Digital 1TB", Price = 40, CategoryId = 1, ImageUrl = "/images/4.jpg" },
            new Product { ProductID = 5, ProductName = "MSI GeForce GTX 1660", Price = 250, CategoryId = 1, ImageUrl = "/images/5.jpg" },
            new Product { ProductID = 6, ProductName = "Cooler Master Hyper 212", Price = 35, CategoryId = 1, ImageUrl = "/images/6.jpg" },
            new Product { ProductID = 7, ProductName = "ASUS ROG Strix B450-F", Price = 90, CategoryId = 1, ImageUrl = "/images/7.jpg" },
            new Product { ProductID = 8, ProductName = "Noctua NH-D15", Price = 90, CategoryId = 1, ImageUrl = "/images/8.jpg" },
            new Product { ProductID = 9, ProductName = "Corsair RM850x", Price = 120, CategoryId = 1, ImageUrl = "/images/9.jpg" },
            new Product { ProductID = 10, ProductName = "Cooler Master MasterBox Q300L", Price = 60, CategoryId = 1, ImageUrl = "/images/10.jpg" },
            new Product { ProductID = 11, ProductName = "Kingston A2000 500GB", Price = 55, CategoryId = 1, ImageUrl = "/images/11.jpg" },
            new Product { ProductID = 12, ProductName = "Corsair iCUE H150i Elite Capellix", Price = 150, CategoryId = 1, ImageUrl = "/images/12.jpg" },
            new Product { ProductID = 13, ProductName = "G.SKILL Ripjaws V 32GB", Price = 180, CategoryId = 1, ImageUrl = "/images/13.jpg" },
            new Product { ProductID = 14, ProductName = "Intel Core i7-10700K", Price = 350, CategoryId = 1, ImageUrl = "/images/14.jpg" },
            new Product { ProductID = 15, ProductName = "ASUS TUF Gaming Z490-Plus", Price = 180, CategoryId = 1, ImageUrl = "/images/15.jpg" },
            new Product { ProductID = 16, ProductName = "Be Quiet! Dark Rock Pro 4", Price = 90, CategoryId = 1, ImageUrl = "/images/16.jpg" },
            new Product { ProductID = 17, ProductName = "Samsung 970 EVO 500GB", Price = 90, CategoryId = 1, ImageUrl = "/images/17.jpg" },
            new Product { ProductID = 18, ProductName = "EVGA GeForce RTX 3070", Price = 500, CategoryId = 1, ImageUrl = "/images/18.jpg" },

    new Product { ProductID = 19, ProductName = "Logitech G502", Price = 60, CategoryId = 2, ImageUrl = "/images/19.jpg" },
    new Product { ProductID = 20, ProductName = "Corsair K95 RGB", Price = 150, CategoryId = 2, ImageUrl = "/images/20.jpg" },
    new Product { ProductID = 21, ProductName = "Samsung Odyssey G7 32", Price = 400, CategoryId = 2, ImageUrl = "/images/21.jpg" },
    new Product { ProductID = 22, ProductName = "Razer Kraken V3", Price = 100, CategoryId = 2, ImageUrl = "/images/22.jpg" },
    new Product { ProductID = 23, ProductName = "JBL Flip 5", Price = 100, CategoryId = 2, ImageUrl = "/images/23.jpg" },
    new Product { ProductID = 24, ProductName = "Logitech G Pro X", Price = 130, CategoryId = 2, ImageUrl = "/images/24.jpg" },
    new Product { ProductID = 25, ProductName = "SteelSeries Apex Pro", Price = 250, CategoryId = 2, ImageUrl = "/images/25.jpg" },
    new Product { ProductID = 26, ProductName = "Alienware AW2521H 24.5", Price = 500, CategoryId = 2, ImageUrl = "/images/26.jpg" },
    new Product { ProductID = 27, ProductName = "Logitech G903 LIGHTSPEED", Price = 130, CategoryId = 2, ImageUrl = "/images/27.jpg" },
    new Product { ProductID = 28, ProductName = "Razer Nari Ultimate", Price = 150, CategoryId = 2, ImageUrl = "/images/28.jpg" },
    new Product { ProductID = 29, ProductName = "HyperX Cloud II", Price = 90, CategoryId = 2, ImageUrl = "/images/29.jpg" },
    new Product { ProductID = 30, ProductName = "BenQ ZOWIE XL2546K", Price = 300, CategoryId = 2, ImageUrl = "/images/30.jpg" },
    new Product { ProductID = 31, ProductName = "Logitech Z906", Price = 200, CategoryId = 2, ImageUrl = "/images/31.jpg" },
    new Product { ProductID = 32, ProductName = "SteelSeries Rival 600", Price = 90, CategoryId = 2, ImageUrl = "/images/32.jpg" },
    new Product { ProductID = 33, ProductName = "Razer DeathAdder Elite", Price = 70, CategoryId = 2, ImageUrl = "/images/33.jpg" },

    new Product { ProductID = 34, ProductName = "TP-Link Archer AX50", Price = 90, CategoryId = 3, ImageUrl = "/images/34.jpg" },
    new Product { ProductID = 35, ProductName = "Netgear Nighthawk R7000", Price = 130, CategoryId = 3, ImageUrl = "/images/35.jpg" },
    new Product { ProductID = 36, ProductName = "TP-Link RE200", Price = 35, CategoryId = 3, ImageUrl = "/images/36.jpg" },
    new Product { ProductID = 37, ProductName = "Google Chromecast", Price = 40, CategoryId = 3, ImageUrl = "/images/37.jpg" },
    new Product { ProductID = 38, ProductName = "ASUS RT-AC68U", Price = 90, CategoryId = 3, ImageUrl = "/images/38.jpg" },
    new Product { ProductID = 39, ProductName = "TP-Link Deco M5", Price = 120, CategoryId = 3, ImageUrl = "/images/39.jpg" },
    new Product { ProductID = 40, ProductName = "D-Link DIR-878", Price = 70, CategoryId = 3, ImageUrl = "/images/40.jpg" },
    new Product { ProductID = 41, ProductName = "Linksys EA7500", Price = 110, CategoryId = 3, ImageUrl = "/images/41.jpg" },
    new Product { ProductID = 42, ProductName = "Netgear Orbi RBK50", Price = 250, CategoryId = 3, ImageUrl = "/images/42.jpg" },
    new Product { ProductID = 43, ProductName = "Tenda Nova MW6", Price = 80, CategoryId = 3, ImageUrl = "/images/43.jpg" },
    new Product { ProductID = 44, ProductName = "Xiaomi Mi WiFi Router 4", Price = 30, CategoryId = 3, ImageUrl = "/images/44.jpg" },
    new Product { ProductID = 45, ProductName = "TP-Link Tether", Price = 40, CategoryId = 3, ImageUrl = "/images/45.jpg" },
    new Product { ProductID = 46, ProductName = "Linksys WRT3200ACM", Price = 160, CategoryId = 3, ImageUrl = "/images/46.jpg" },
    new Product { ProductID = 47, ProductName = "Ubiquiti UniFi Dream Machine", Price = 300, CategoryId = 3, ImageUrl = "/images/47.jpg" }
            );
        }
    }
}