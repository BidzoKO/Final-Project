using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dataInitialisation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "order_detail",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_detail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderOrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderOrderDetail", x => new { x.OrderDetailId, x.OrderId });
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    first_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password_hash = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    balance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_order_user",
                        column: x => x.user_ID,
                        principalTable: "user",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "order_detail_map",
                columns: table => new
                {
                    order_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order_detail_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order-details", x => new { x.order_ID, x.order_detail_ID });
                    table.ForeignKey(
                        name: "FK_order-details_order",
                        column: x => x.order_ID,
                        principalTable: "order",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_order-details_order_detail",
                        column: x => x.order_detail_ID,
                        principalTable: "order_detail",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "ID", "description", "name", "price", "quantity", "status" },
                values: new object[,]
                {
                    { new Guid("01f3c978-782c-433a-b92c-fcface3a8334"), "Description", "bread", 5.5, 100, 0 },
                    { new Guid("774215df-1256-4e02-bbbe-b8ebda5b1b2c"), "Description", "banana", 5.5, 100, 0 },
                    { new Guid("c8b41a08-1332-40c6-9beb-98ada66047e7"), "Description", "apple", 5.5, 100, 0 },
                    { new Guid("f1af378a-e041-41b9-b99f-fd973dd9ce1d"), "Description", "grape", 5.5, 100, 0 }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "ID", "balance", "email", "first_name", "last_name", "password_hash" },
                values: new object[] { new Guid("26e27792-2b87-4538-a012-bfcc043864e3"), 1000.0, "Test@email.com", "Name", "LastName", "12345678" });

            migrationBuilder.CreateIndex(
                name: "IX_order_user_ID",
                table: "order",
                column: "user_ID");

            migrationBuilder.CreateIndex(
                name: "IX_order_detail_map_order_detail_ID",
                table: "order_detail_map",
                column: "order_detail_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order_detail_map");

            migrationBuilder.DropTable(
                name: "OrderOrderDetail");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "order_detail");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
