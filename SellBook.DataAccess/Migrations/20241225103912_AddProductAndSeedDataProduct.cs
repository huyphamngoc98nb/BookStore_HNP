using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SellBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductAndSeedDataProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("0a8bbf34-5827-4f88-9b2e-34e75f738d2f"), "Eric Evans", "Addressing complexity in software development through domain-driven design.", "9780321125217", 69.0, 65.0, 55.0, 60.0, "Domain-Driven Design" },
                    { new Guid("12b53bfb-46fa-4c03-bd36-f299fc94eb5e"), "Jon Bentley", "Insights into coding and problem-solving techniques for software developers.", "9780201657883", 49.0, 45.0, 35.0, 40.0, "Programming Pearls" },
                    { new Guid("244b014e-5412-4de0-8f1e-f7e23c6b0cc3"), "Douglas Crockford", "A concise guide to JavaScript's best features and practices.", "9780596517748", 29.0, 25.0, 15.0, 20.0, "JavaScript: The Good Parts" },
                    { new Guid("2b92dc6e-1dc7-4aaf-b21c-6825dbadfc2f"), "Nigel Poulton", "Learn Docker in-depth and practical use cases.", "9781521822807", 39.0, 35.0, 25.0, 30.0, "Docker Deep Dive" },
                    { new Guid("3ec7e0a2-9c2d-4e45-8eb5-60b251e64523"), "Steve McConnell", "A practical handbook of software construction focusing on best coding practices.", "9780735619678", 59.0, 55.0, 45.0, 50.0, "Code Complete" },
                    { new Guid("47f2b9f2-98b8-4b50-b3b1-53d6db6ccdd2"), "Eric Matthes", "A hands-on, project-based introduction to Python programming.", "9781593279288", 44.0, 40.0, 30.0, 35.0, "Python Crash Course" },
                    { new Guid("4c40c99c-e9e4-4c8b-bb8d-dfa19b9d7cb2"), "Alex Banks, Eve Porcello", "A hands-on guide to building web applications using React.", "9781491954621", 44.0, 40.0, 30.0, 35.0, "Learning React" },
                    { new Guid("5b462e1e-d7c7-47d6-a9b6-fd343cfdb8d4"), "Robert C. Martin", "A guide to software structure and architecture principles.", "9780134494166", 59.0, 55.0, 45.0, 50.0, "Clean Architecture" },
                    { new Guid("5c2924a8-9051-4760-bc29-9ecbcf16d1f7"), "Kelsey Hightower, Brendan Burns, Joe Beda", "Dive into Kubernetes concepts and deploy containerized applications.", "9781491935675", 59.0, 55.0, 45.0, 50.0, "Kubernetes Up & Running" },
                    { new Guid("62c8a7da-5f41-4ef2-8049-06415357e204"), "Brett Slatkin", "59 specific ways to improve Python programs.", "9780134034287", 44.0, 40.0, 30.0, 35.0, "Effective Python" },
                    { new Guid("6f34a8de-d194-42e7-9462-67ea5fd8577e"), "Niall Richard Murphy, Betsy Beyer, Chris Jones, Jennifer Petoff", "Insights into Google's approach to reliability and operational excellence.", "9781491929124", 79.0, 75.0, 65.0, 70.0, "Site Reliability Engineering" },
                    { new Guid("71aebec8-5a88-4c6e-a892-39ad84662d6c"), "Stuart Russell, Peter Norvig", "A comprehensive overview of AI principles and techniques.", "9780136042594", 99.0, 95.0, 85.0, 90.0, "Artificial Intelligence: A Modern Approach" },
                    { new Guid("7d5456f5-4b0d-4ba6-80ee-b14d8d6cf3e8"), "Jeff Geerling", "Simple IT automation through Ansible.", "9780989551335", 39.0, 35.0, 25.0, 30.0, "Ansible for DevOps" },
                    { new Guid("84d3d527-7052-4e27-8713-b1d7314c2f19"), "Joshua Bloch", "Best practices and design principles for Java programming.", "9780134685991", 59.0, 55.0, 45.0, 50.0, "Effective Java" },
                    { new Guid("89be1842-d30a-4010-9d53-bfdb6b892814"), "Donald E. Knuth", "A classic series covering algorithms and programming techniques.", "9780201896831", 199.0, 190.0, 180.0, 185.0, "The Art of Computer Programming" },
                    { new Guid("89d06b93-f835-4d58-8170-8fbe3156ec27"), "Jez Humble, David Farley", "Reliable software releases through build, test, and deployment automation.", "9780321601919", 59.0, 55.0, 45.0, 50.0, "Continuous Delivery" },
                    { new Guid("8a9b2967-bd3e-4d75-81f5-64c5e191a110"), "Robert C. Martin", "A Handbook of Agile Software Craftsmanship focusing on writing readable and maintainable code.", "9780132350884", 49.0, 45.0, 35.0, 40.0, "Clean Code" },
                    { new Guid("97f70eeb-82a1-4c91-9f92-8a07bbdb33e3"), "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein", "Comprehensive guide on algorithms for computer science students and professionals.", "9780262033848", 89.0, 85.0, 75.0, 80.0, "Introduction to Algorithms" },
                    { new Guid("9e25e49f-5a3d-4d21-8b2b-711b70e413f8"), "Michael Sipser", "A theoretical approach to computation and algorithms.", "9781133187790", 79.0, 75.0, 65.0, 70.0, "Introduction to the Theory of Computation" },
                    { new Guid("a15cb537-c97e-4c2e-bf10-159d7b3a191d"), "Jon Skeet", "A comprehensive guide to mastering C# features and techniques.", "9781617294532", 59.0, 55.0, 45.0, 50.0, "C# in Depth" },
                    { new Guid("af3df834-5d0a-4629-a1b4-57dfabdd43cd"), "Gene Kim, Kevin Behr, George Spafford", "A novel about IT, DevOps, and helping businesses win.", "9780988262591", 49.0, 45.0, 35.0, 40.0, "The Phoenix Project" },
                    { new Guid("bb3b0412-d68f-4a22-a12d-56cb8d6e7325"), "Gayle Laakmann McDowell", "150 programming interview questions and solutions to prepare for technical interviews.", "9780984782857", 69.0, 65.0, 55.0, 60.0, "Cracking the Coding Interview" },
                    { new Guid("bb97d76f-fb7b-471b-a69c-fd90d0f8a70e"), "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", "Elements of Reusable Object-Oriented Software detailing classic design patterns.", "9780201633610", 69.0, 65.0, 55.0, 60.0, "Design Patterns" },
                    { new Guid("bc3d12e4-efdd-40f3-96e4-4fcf53e6f777"), "Andrew Hunt, David Thomas", "Tips and techniques for software developers to improve coding and problem-solving skills.", "9780201616224", 59.0, 55.0, 45.0, 50.0, "The Pragmatic Programmer" },
                    { new Guid("c1d5a61b-d9e2-44f3-8ed1-26851e5fc0b8"), "Mike Cohn", "Guidance on estimating and planning in agile software development.", "9780131479418", 49.0, 45.0, 35.0, 40.0, "Agile Estimating and Planning" },
                    { new Guid("c2459f93-3f73-45c9-ae86-65b3cd8a4b60"), "Martin Fowler", "Improving the design of existing code for better maintainability.", "9780201485677", 64.0, 60.0, 50.0, 55.0, "Refactoring" },
                    { new Guid("c8b6c11f-7b5d-4051-9c2a-e0b07c2fc47e"), "Kent Beck", "Introduction to test-driven development with practical examples.", "9780321146533", 39.0, 35.0, 25.0, 30.0, "Test-Driven Development by Example" },
                    { new Guid("d7e4d235-42a7-44ee-b2af-508e488c0bf2"), "Eric Freeman, Elisabeth Robson", "An approachable guide to software design patterns with engaging visuals.", "9780596007126", 59.0, 55.0, 45.0, 50.0, "Head First Design Patterns" },
                    { new Guid("e4534f70-2a4a-4c21-919e-cfd1d6176e75"), "Michael Feathers", "Techniques to improve and refactor legacy codebases effectively.", "9780131177055", 59.0, 55.0, 45.0, 50.0, "Working Effectively with Legacy Code" },
                    { new Guid("e5b4a63a-366e-47a3-8ae4-0d3171c455e3"), "Ian Goodfellow, Yoshua Bengio, Aaron Courville", "A comprehensive introduction to deep learning concepts and techniques.", "9780262035613", 89.0, 85.0, 75.0, 80.0, "Deep Learning" },
                    { new Guid("ed32c3ad-9b36-4c6b-8612-2b2ed4d8e17e"), "Kyle Simpson", "A deep dive into the core mechanics of JavaScript and modern features.", "9781491904244", 39.0, 35.0, 25.0, 30.0, "You Don't Know JS" },
                    { new Guid("fa8dcdb8-f4f8-4042-9011-56737a69b914"), "Marijn Haverbeke", "A modern introduction to JavaScript, covering core programming concepts.", "9781593279509", 49.0, 45.0, 35.0, 40.0, "Eloquent JavaScript" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
