using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SellBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifySeedDataCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28287294-9e96-4755-93af-91cf53a8ad58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d26d1328-c894-45a6-90a6-3b1f116a8646"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a110"),
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a111"), 2, "Adventure" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a112"), 3, "Fantasy" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a113"), 4, "Science Fiction" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a114"), 5, "Romance" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a115"), 6, "Mystery" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a116"), 7, "Thriller" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a117"), 8, "Horror" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a118"), 9, "Historical" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a119"), 10, "Biography" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a120"), 11, "Self-Help" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a121"), 12, "Health" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a122"), 13, "Travel" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a123"), 14, "Cooking" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a124"), 15, "Art" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a125"), 16, "Music" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a126"), 17, "Photography" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a127"), 18, "Religion" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a128"), 19, "Spirituality" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a129"), 20, "Poetry" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a130"), 21, "Drama" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a131"), 22, "Comics" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a132"), 23, "Graphic Novels" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a133"), 24, "Children's Books" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a134"), 25, "Young Adult" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a135"), 26, "Education" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a136"), 27, "Science" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a137"), 28, "Technology" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a138"), 29, "Engineering" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a139"), 30, "Mathematics" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a140"), 31, "Politics" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a141"), 32, "Economics" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a142"), 33, "Business" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a143"), 34, "Management" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a144"), 35, "Law" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a145"), 36, "True Crime" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a146"), 37, "Anthology" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a147"), 38, "Classic" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a148"), 39, "Satire" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a149"), 40, "Essay" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a150"), 41, "Memoir" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a151"), 42, "Humor" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a152"), 43, "Parenting" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a153"), 44, "Relationships" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a154"), 45, "Gardening" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a155"), 46, "Sports" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a156"), 47, "Fitness" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a157"), 48, "Animals" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a158"), 49, "Nature" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a159"), 50, "Environment" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a111"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a112"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a113"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a114"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a115"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a116"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a117"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a118"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a119"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a120"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a121"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a122"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a123"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a124"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a125"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a126"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a127"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a128"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a129"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a130"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a131"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a132"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a133"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a134"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a135"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a136"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a137"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a138"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a139"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a140"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a141"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a142"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a143"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a144"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a145"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a146"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a147"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a148"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a149"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a150"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a151"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a152"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a153"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a154"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a155"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a156"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a157"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a158"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a159"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a110"),
                column: "DisplayOrder",
                value: 2);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("28287294-9e96-4755-93af-91cf53a8ad58"), 3, "Action" },
                    { new Guid("d26d1328-c894-45a6-90a6-3b1f116a8646"), 1, "Action" }
                });
        }
    }
}
