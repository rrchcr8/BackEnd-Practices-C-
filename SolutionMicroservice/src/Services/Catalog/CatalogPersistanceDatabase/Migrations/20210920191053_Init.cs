﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogPersistanceDatabase.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 581m },
                    { 73, "Description for product 73", "Product 73", 532m },
                    { 72, "Description for product 72", "Product 72", 522m },
                    { 71, "Description for product 71", "Product 71", 395m },
                    { 70, "Description for product 70", "Product 70", 156m },
                    { 69, "Description for product 69", "Product 69", 114m },
                    { 68, "Description for product 68", "Product 68", 349m },
                    { 67, "Description for product 67", "Product 67", 783m },
                    { 66, "Description for product 66", "Product 66", 607m },
                    { 65, "Description for product 65", "Product 65", 231m },
                    { 64, "Description for product 64", "Product 64", 850m },
                    { 63, "Description for product 63", "Product 63", 249m },
                    { 62, "Description for product 62", "Product 62", 162m },
                    { 61, "Description for product 61", "Product 61", 380m },
                    { 60, "Description for product 60", "Product 60", 158m },
                    { 59, "Description for product 59", "Product 59", 900m },
                    { 58, "Description for product 58", "Product 58", 858m },
                    { 57, "Description for product 57", "Product 57", 339m },
                    { 56, "Description for product 56", "Product 56", 884m },
                    { 55, "Description for product 55", "Product 55", 565m },
                    { 54, "Description for product 54", "Product 54", 235m },
                    { 53, "Description for product 53", "Product 53", 696m },
                    { 74, "Description for product 74", "Product 74", 322m },
                    { 52, "Description for product 52", "Product 52", 545m },
                    { 75, "Description for product 75", "Product 75", 241m },
                    { 77, "Description for product 77", "Product 77", 714m },
                    { 98, "Description for product 98", "Product 98", 232m },
                    { 97, "Description for product 97", "Product 97", 193m },
                    { 96, "Description for product 96", "Product 96", 299m },
                    { 95, "Description for product 95", "Product 95", 662m },
                    { 94, "Description for product 94", "Product 94", 166m },
                    { 93, "Description for product 93", "Product 93", 126m },
                    { 92, "Description for product 92", "Product 92", 235m },
                    { 91, "Description for product 91", "Product 91", 161m },
                    { 90, "Description for product 90", "Product 90", 424m },
                    { 89, "Description for product 89", "Product 89", 641m },
                    { 88, "Description for product 88", "Product 88", 230m },
                    { 87, "Description for product 87", "Product 87", 566m },
                    { 86, "Description for product 86", "Product 86", 173m },
                    { 85, "Description for product 85", "Product 85", 186m },
                    { 84, "Description for product 84", "Product 84", 405m },
                    { 83, "Description for product 83", "Product 83", 901m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Description for product 82", "Product 82", 655m },
                    { 81, "Description for product 81", "Product 81", 653m },
                    { 80, "Description for product 80", "Product 80", 991m },
                    { 79, "Description for product 79", "Product 79", 533m },
                    { 78, "Description for product 78", "Product 78", 685m },
                    { 76, "Description for product 76", "Product 76", 916m },
                    { 51, "Description for product 51", "Product 51", 544m },
                    { 50, "Description for product 50", "Product 50", 673m },
                    { 49, "Description for product 49", "Product 49", 266m },
                    { 22, "Description for product 22", "Product 22", 697m },
                    { 21, "Description for product 21", "Product 21", 259m },
                    { 20, "Description for product 20", "Product 20", 503m },
                    { 19, "Description for product 19", "Product 19", 264m },
                    { 18, "Description for product 18", "Product 18", 657m },
                    { 17, "Description for product 17", "Product 17", 449m },
                    { 16, "Description for product 16", "Product 16", 389m },
                    { 15, "Description for product 15", "Product 15", 457m },
                    { 14, "Description for product 14", "Product 14", 323m },
                    { 13, "Description for product 13", "Product 13", 456m },
                    { 12, "Description for product 12", "Product 12", 149m },
                    { 11, "Description for product 11", "Product 11", 770m },
                    { 10, "Description for product 10", "Product 10", 751m },
                    { 9, "Description for product 9", "Product 9", 481m },
                    { 8, "Description for product 8", "Product 8", 229m },
                    { 7, "Description for product 7", "Product 7", 230m },
                    { 6, "Description for product 6", "Product 6", 454m },
                    { 5, "Description for product 5", "Product 5", 849m },
                    { 4, "Description for product 4", "Product 4", 910m },
                    { 3, "Description for product 3", "Product 3", 646m },
                    { 2, "Description for product 2", "Product 2", 720m },
                    { 23, "Description for product 23", "Product 23", 480m },
                    { 24, "Description for product 24", "Product 24", 787m },
                    { 25, "Description for product 25", "Product 25", 110m },
                    { 26, "Description for product 26", "Product 26", 790m },
                    { 48, "Description for product 48", "Product 48", 518m },
                    { 47, "Description for product 47", "Product 47", 237m },
                    { 46, "Description for product 46", "Product 46", 118m },
                    { 45, "Description for product 45", "Product 45", 354m },
                    { 44, "Description for product 44", "Product 44", 795m },
                    { 43, "Description for product 43", "Product 43", 982m },
                    { 42, "Description for product 42", "Product 42", 343m },
                    { 41, "Description for product 41", "Product 41", 361m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Description for product 40", "Product 40", 942m },
                    { 39, "Description for product 39", "Product 39", 224m },
                    { 99, "Description for product 99", "Product 99", 663m },
                    { 38, "Description for product 38", "Product 38", 926m },
                    { 36, "Description for product 36", "Product 36", 400m },
                    { 35, "Description for product 35", "Product 35", 309m },
                    { 34, "Description for product 34", "Product 34", 206m },
                    { 33, "Description for product 33", "Product 33", 365m },
                    { 32, "Description for product 32", "Product 32", 262m },
                    { 31, "Description for product 31", "Product 31", 619m },
                    { 30, "Description for product 30", "Product 30", 631m },
                    { 29, "Description for product 29", "Product 29", 979m },
                    { 28, "Description for product 28", "Product 28", 168m },
                    { 27, "Description for product 27", "Product 27", 174m },
                    { 37, "Description for product 37", "Product 37", 994m },
                    { 100, "Description for product 100", "Product 100", 746m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 16 },
                    { 73, 73, 13 },
                    { 72, 72, 4 },
                    { 71, 71, 4 },
                    { 70, 70, 4 },
                    { 69, 69, 9 },
                    { 68, 68, 6 },
                    { 67, 67, 17 },
                    { 66, 66, 4 },
                    { 65, 65, 9 },
                    { 64, 64, 2 },
                    { 63, 63, 2 },
                    { 62, 62, 1 },
                    { 61, 61, 8 },
                    { 60, 60, 10 },
                    { 59, 59, 3 },
                    { 58, 58, 8 },
                    { 57, 57, 15 },
                    { 56, 56, 16 },
                    { 55, 55, 8 },
                    { 54, 54, 1 },
                    { 53, 53, 0 },
                    { 74, 74, 9 },
                    { 52, 52, 12 },
                    { 75, 75, 19 },
                    { 77, 77, 12 },
                    { 98, 98, 4 },
                    { 97, 97, 3 },
                    { 96, 96, 17 },
                    { 95, 95, 19 },
                    { 94, 94, 8 },
                    { 93, 93, 16 },
                    { 92, 92, 5 },
                    { 91, 91, 12 },
                    { 90, 90, 10 },
                    { 89, 89, 11 },
                    { 88, 88, 8 },
                    { 87, 87, 12 },
                    { 86, 86, 11 },
                    { 85, 85, 2 },
                    { 84, 84, 1 },
                    { 83, 83, 18 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 7 },
                    { 81, 81, 3 },
                    { 80, 80, 9 },
                    { 79, 79, 18 },
                    { 78, 78, 2 },
                    { 76, 76, 3 },
                    { 51, 51, 19 },
                    { 50, 50, 2 },
                    { 49, 49, 9 },
                    { 22, 22, 19 },
                    { 21, 21, 10 },
                    { 20, 20, 17 },
                    { 19, 19, 17 },
                    { 18, 18, 12 },
                    { 17, 17, 5 },
                    { 16, 16, 19 },
                    { 15, 15, 13 },
                    { 14, 14, 16 },
                    { 13, 13, 6 },
                    { 12, 12, 7 },
                    { 11, 11, 18 },
                    { 10, 10, 12 },
                    { 9, 9, 4 },
                    { 8, 8, 6 },
                    { 7, 7, 9 },
                    { 6, 6, 1 },
                    { 5, 5, 5 },
                    { 4, 4, 7 },
                    { 3, 3, 6 },
                    { 2, 2, 17 },
                    { 23, 23, 1 },
                    { 24, 24, 18 },
                    { 25, 25, 3 },
                    { 26, 26, 14 },
                    { 48, 48, 5 },
                    { 47, 47, 11 },
                    { 46, 46, 14 },
                    { 45, 45, 19 },
                    { 44, 44, 19 },
                    { 43, 43, 6 },
                    { 42, 42, 6 },
                    { 41, 41, 18 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 7 },
                    { 39, 39, 18 },
                    { 99, 99, 10 },
                    { 38, 38, 0 },
                    { 36, 36, 8 },
                    { 35, 35, 6 },
                    { 34, 34, 19 },
                    { 33, 33, 10 },
                    { 32, 32, 13 },
                    { 31, 31, 3 },
                    { 30, 30, 2 },
                    { 29, 29, 3 },
                    { 28, 28, 8 },
                    { 27, 27, 12 },
                    { 37, 37, 14 },
                    { 100, 100, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
