using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SellBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a110"), 1, "Action" },
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
