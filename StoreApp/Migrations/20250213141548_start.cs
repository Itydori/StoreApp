using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "InternalParts" },
                    { 2, "ExternalParts" },
                    { 3, "Connectivity" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryId", "ImageUrl", "Price", "ProductName", "Summary" },
                values: new object[,]
                {
                    { 1, 1, "/images/1.jpg", 200m, "Ryzen 5 3600", "" },
                    { 2, 1, "/images/2.jpg", 80m, "Corsair Vengeance 16GB", "" },
                    { 3, 1, "/images/3.jpg", 120m, "Samsung 970 EVO Plus 1TB", "" },
                    { 4, 1, "/images/4.jpg", 40m, "Western Digital 1TB", "" },
                    { 5, 1, "/images/5.jpg", 250m, "MSI GeForce GTX 1660", "" },
                    { 6, 1, "/images/6.jpg", 35m, "Cooler Master Hyper 212", "" },
                    { 7, 1, "/images/7.jpg", 90m, "ASUS ROG Strix B450-F", "" },
                    { 8, 1, "/images/8.jpg", 90m, "Noctua NH-D15", "" },
                    { 9, 1, "/images/9.jpg", 120m, "Corsair RM850x", "" },
                    { 10, 1, "/images/10.jpg", 60m, "Cooler Master MasterBox Q300L", "" },
                    { 11, 1, "/images/11.jpg", 55m, "Kingston A2000 500GB", "" },
                    { 12, 1, "/images/12.jpg", 150m, "Corsair iCUE H150i Elite Capellix", "" },
                    { 13, 1, "/images/13.jpg", 180m, "G.SKILL Ripjaws V 32GB", "" },
                    { 14, 1, "/images/14.jpg", 350m, "Intel Core i7-10700K", "" },
                    { 15, 1, "/images/15.jpg", 180m, "ASUS TUF Gaming Z490-Plus", "" },
                    { 16, 1, "/images/16.jpg", 90m, "Be Quiet! Dark Rock Pro 4", "" },
                    { 17, 1, "/images/17.jpg", 90m, "Samsung 970 EVO 500GB", "" },
                    { 18, 1, "/images/18.jpg", 500m, "EVGA GeForce RTX 3070", "" },
                    { 19, 2, "/images/19.jpg", 60m, "Logitech G502", "" },
                    { 20, 2, "/images/20.jpg", 150m, "Corsair K95 RGB", "" },
                    { 21, 2, "/images/21.jpg", 400m, "Samsung Odyssey G7 32", "" },
                    { 22, 2, "/images/22.jpg", 100m, "Razer Kraken V3", "" },
                    { 23, 2, "/images/23.jpg", 100m, "JBL Flip 5", "" },
                    { 24, 2, "/images/24.jpg", 130m, "Logitech G Pro X", "" },
                    { 25, 2, "/images/25.jpg", 250m, "SteelSeries Apex Pro", "" },
                    { 26, 2, "/images/26.jpg", 500m, "Alienware AW2521H 24.5", "" },
                    { 27, 2, "/images/27.jpg", 130m, "Logitech G903 LIGHTSPEED", "" },
                    { 28, 2, "/images/28.jpg", 150m, "Razer Nari Ultimate", "" },
                    { 29, 2, "/images/29.jpg", 90m, "HyperX Cloud II", "" },
                    { 30, 2, "/images/30.jpg", 300m, "BenQ ZOWIE XL2546K", "" },
                    { 31, 2, "/images/31.jpg", 200m, "Logitech Z906", "" },
                    { 32, 2, "/images/32.jpg", 90m, "SteelSeries Rival 600", "" },
                    { 33, 2, "/images/33.jpg", 70m, "Razer DeathAdder Elite", "" },
                    { 34, 3, "/images/34.jpg", 90m, "TP-Link Archer AX50", "" },
                    { 35, 3, "/images/35.jpg", 130m, "Netgear Nighthawk R7000", "" },
                    { 36, 3, "/images/36.jpg", 35m, "TP-Link RE200", "" },
                    { 37, 3, "/images/37.jpg", 40m, "Google Chromecast", "" },
                    { 38, 3, "/images/38.jpg", 90m, "ASUS RT-AC68U", "" },
                    { 39, 3, "/images/39.jpg", 120m, "TP-Link Deco M5", "" },
                    { 40, 3, "/images/40.jpg", 70m, "D-Link DIR-878", "" },
                    { 41, 3, "/images/41.jpg", 110m, "Linksys EA7500", "" },
                    { 42, 3, "/images/42.jpg", 250m, "Netgear Orbi RBK50", "" },
                    { 43, 3, "/images/43.jpg", 80m, "Tenda Nova MW6", "" },
                    { 44, 3, "/images/44.jpg", 30m, "Xiaomi Mi WiFi Router 4", "" },
                    { 45, 3, "/images/45.jpg", 40m, "TP-Link Tether", "" },
                    { 46, 3, "/images/46.jpg", 160m, "Linksys WRT3200ACM", "" },
                    { 47, 3, "/images/47.jpg", 300m, "Ubiquiti UniFi Dream Machine", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
