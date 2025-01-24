using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SellBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InsertSeedDataCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("28287294-9e96-4755-93af-91cf53a8ad58"), 3, "Action" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a110"), 2, "Action" },
                    { new Guid("d26d1328-c894-45a6-90a6-3b1f116a8646"), 1, "Action" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28287294-9e96-4755-93af-91cf53a8ad58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a110"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d26d1328-c894-45a6-90a6-3b1f116a8646"));
        }
    }
}
