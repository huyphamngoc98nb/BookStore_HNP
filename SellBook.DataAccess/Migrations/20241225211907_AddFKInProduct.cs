using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFKInProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a8bbf34-5827-4f88-9b2e-34e75f738d2f"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b53bfb-46fa-4c03-bd36-f299fc94eb5e"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("244b014e-5412-4de0-8f1e-f7e23c6b0cc3"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b92dc6e-1dc7-4aaf-b21c-6825dbadfc2f"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ec7e0a2-9c2d-4e45-8eb5-60b251e64523"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47f2b9f2-98b8-4b50-b3b1-53d6db6ccdd2"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c40c99c-e9e4-4c8b-bb8d-dfa19b9d7cb2"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b462e1e-d7c7-47d6-a9b6-fd343cfdb8d4"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c2924a8-9051-4760-bc29-9ecbcf16d1f7"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62c8a7da-5f41-4ef2-8049-06415357e204"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f34a8de-d194-42e7-9462-67ea5fd8577e"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71aebec8-5a88-4c6e-a892-39ad84662d6c"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d5456f5-4b0d-4ba6-80ee-b14d8d6cf3e8"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84d3d527-7052-4e27-8713-b1d7314c2f19"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89be1842-d30a-4010-9d53-bfdb6b892814"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89d06b93-f835-4d58-8170-8fbe3156ec27"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a110"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97f70eeb-82a1-4c91-9f92-8a07bbdb33e3"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e25e49f-5a3d-4d21-8b2b-711b70e413f8"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a15cb537-c97e-4c2e-bf10-159d7b3a191d"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af3df834-5d0a-4629-a1b4-57dfabdd43cd"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb3b0412-d68f-4a22-a12d-56cb8d6e7325"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb97d76f-fb7b-471b-a69c-fd90d0f8a70e"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc3d12e4-efdd-40f3-96e4-4fcf53e6f777"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1d5a61b-d9e2-44f3-8ed1-26851e5fc0b8"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2459f93-3f73-45c9-ae86-65b3cd8a4b60"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8b6c11f-7b5d-4051-9c2a-e0b07c2fc47e"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7e4d235-42a7-44ee-b2af-508e488c0bf2"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4534f70-2a4a-4c21-919e-cfd1d6176e75"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5b4a63a-366e-47a3-8ae4-0d3171c455e3"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed32c3ad-9b36-4c6b-8612-2b2ed4d8e17e"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa8dcdb8-f4f8-4042-9011-56737a69b914"),
                column: "CategoryId",
                value: new Guid("8A9B2967-BD3E-4D75-81F5-64C5E191A137"));

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");
        }
    }
}
