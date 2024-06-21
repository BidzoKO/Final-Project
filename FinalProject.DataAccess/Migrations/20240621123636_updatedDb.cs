using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order-details_order",
                table: "order_detail_map");

            migrationBuilder.DropForeignKey(
                name: "FK_order-details_order_detail",
                table: "order_detail_map");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order-details",
                table: "order_detail_map");

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "ID",
                keyValue: new Guid("01f3c978-782c-433a-b92c-fcface3a8334"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "ID",
                keyValue: new Guid("774215df-1256-4e02-bbbe-b8ebda5b1b2c"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "ID",
                keyValue: new Guid("c8b41a08-1332-40c6-9beb-98ada66047e7"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "ID",
                keyValue: new Guid("f1af378a-e041-41b9-b99f-fd973dd9ce1d"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "ID",
                keyValue: new Guid("26e27792-2b87-4538-a012-bfcc043864e3"));

            migrationBuilder.AddColumn<Guid>(
                name: "product_ID",
                table: "order_detail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_order_detail_map",
                table: "order_detail_map",
                columns: new[] { "order_ID", "order_detail_ID" });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "ID", "description", "name", "price", "quantity", "status" },
                values: new object[,]
                {
                    { new Guid("0b61892c-0057-43af-924f-56d4eba30f12"), "Description", "grape", 5.5, 100, 0 },
                    { new Guid("90621c13-9308-44ee-8265-cee9dc141453"), "Description", "banana", 5.5, 100, 0 },
                    { new Guid("cc22db03-3488-48d3-a849-425facc29396"), "Description", "apple", 5.5, 100, 0 },
                    { new Guid("dc6bc6e6-c90b-4f56-b8b8-e062eed60b4c"), "Description", "bread", 5.5, 100, 0 }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "ID", "balance", "email", "first_name", "last_name", "password_hash" },
                values: new object[] { new Guid("07d80dac-5c06-41d7-bdcb-c56b23eac492"), 1000.0, "Test@email.com", "Name", "LastName", "12345678" });

            migrationBuilder.CreateIndex(
                name: "IX_order_detail_product_ID",
                table: "order_detail",
                column: "product_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_order_detail_product",
                table: "order_detail",
                column: "product_ID",
                principalTable: "product",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_order_detail_map_order",
                table: "order_detail_map",
                column: "order_ID",
                principalTable: "order",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_order_detail_map_order_detail",
                table: "order_detail_map",
                column: "order_detail_ID",
                principalTable: "order_detail",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_detail_product",
                table: "order_detail");

            migrationBuilder.DropForeignKey(
                name: "FK_order_detail_map_order",
                table: "order_detail_map");

            migrationBuilder.DropForeignKey(
                name: "FK_order_detail_map_order_detail",
                table: "order_detail_map");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order_detail_map",
                table: "order_detail_map");

            migrationBuilder.DropIndex(
                name: "IX_order_detail_product_ID",
                table: "order_detail");

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "ID",
                keyValue: new Guid("0b61892c-0057-43af-924f-56d4eba30f12"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "ID",
                keyValue: new Guid("90621c13-9308-44ee-8265-cee9dc141453"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "ID",
                keyValue: new Guid("cc22db03-3488-48d3-a849-425facc29396"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "ID",
                keyValue: new Guid("dc6bc6e6-c90b-4f56-b8b8-e062eed60b4c"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "ID",
                keyValue: new Guid("07d80dac-5c06-41d7-bdcb-c56b23eac492"));

            migrationBuilder.DropColumn(
                name: "product_ID",
                table: "order_detail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order-details",
                table: "order_detail_map",
                columns: new[] { "order_ID", "order_detail_ID" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_order-details_order",
                table: "order_detail_map",
                column: "order_ID",
                principalTable: "order",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_order-details_order_detail",
                table: "order_detail_map",
                column: "order_detail_ID",
                principalTable: "order_detail",
                principalColumn: "ID");
        }
    }
}
