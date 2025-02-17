﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SellBook.Models;
using SellBook.Models.Models;

namespace SellBook.DataAccess.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a110"), Name = "Action", DisplayOrder = 1 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a111"), Name = "Adventure", DisplayOrder = 2 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a112"), Name = "Fantasy", DisplayOrder = 3 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a113"), Name = "Science Fiction", DisplayOrder = 4 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a114"), Name = "Romance", DisplayOrder = 5 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a115"), Name = "Mystery", DisplayOrder = 6 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a116"), Name = "Thriller", DisplayOrder = 7 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a117"), Name = "Horror", DisplayOrder = 8 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a118"), Name = "Historical", DisplayOrder = 9 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a119"), Name = "Biography", DisplayOrder = 10 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a120"), Name = "Self-Help", DisplayOrder = 11 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a121"), Name = "Health", DisplayOrder = 12 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a122"), Name = "Travel", DisplayOrder = 13 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a123"), Name = "Cooking", DisplayOrder = 14 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a124"), Name = "Art", DisplayOrder = 15 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a125"), Name = "Music", DisplayOrder = 16 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a126"), Name = "Photography", DisplayOrder = 17 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a127"), Name = "Religion", DisplayOrder = 18 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a128"), Name = "Spirituality", DisplayOrder = 19 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a129"), Name = "Poetry", DisplayOrder = 20 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a130"), Name = "Drama", DisplayOrder = 21 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a131"), Name = "Comics", DisplayOrder = 22 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a132"), Name = "Graphic Novels", DisplayOrder = 23 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a133"), Name = "Children's Books", DisplayOrder = 24 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a134"), Name = "Young Adult", DisplayOrder = 25 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a135"), Name = "Education", DisplayOrder = 26 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a136"), Name = "Science", DisplayOrder = 27 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a137"), Name = "Technology", DisplayOrder = 28 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a138"), Name = "Engineering", DisplayOrder = 29 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a139"), Name = "Mathematics", DisplayOrder = 30 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a140"), Name = "Politics", DisplayOrder = 31 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a141"), Name = "Economics", DisplayOrder = 32 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a142"), Name = "Business", DisplayOrder = 33 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a143"), Name = "Management", DisplayOrder = 34 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a144"), Name = "Law", DisplayOrder = 35 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a145"), Name = "True Crime", DisplayOrder = 36 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a146"), Name = "Anthology", DisplayOrder = 37 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a147"), Name = "Classic", DisplayOrder = 38 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a148"), Name = "Satire", DisplayOrder = 39 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a149"), Name = "Essay", DisplayOrder = 40 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a150"), Name = "Memoir", DisplayOrder = 41 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a151"), Name = "Humor", DisplayOrder = 42 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a152"), Name = "Parenting", DisplayOrder = 43 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a153"), Name = "Relationships", DisplayOrder = 44 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a154"), Name = "Gardening", DisplayOrder = 45 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a155"), Name = "Sports", DisplayOrder = 46 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a156"), Name = "Fitness", DisplayOrder = 47 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a157"), Name = "Animals", DisplayOrder = 48 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a158"), Name = "Nature", DisplayOrder = 49 },
    new Category { Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a159"), Name = "Environment", DisplayOrder = 50 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.Parse("8a9b2967-bd3e-4d75-81f5-64c5e191a110"),
                    Title = "Clean Code",
                    Author = "Robert C. Martin",
                    Description = "A Handbook of Agile Software Craftsmanship focusing on writing readable and maintainable code.",
                    ISBN = "9780132350884",
                    ListPrice = 49,
                    Price = 45,
                    Price50 = 40,
                    Price100 = 35,
                    ImageUrl = "",
                },
new Product
{
    Id = Guid.Parse("bc3d12e4-efdd-40f3-96e4-4fcf53e6f777"),
    Title = "The Pragmatic Programmer",
    Author = "Andrew Hunt, David Thomas",
    Description = "Tips and techniques for software developers to improve coding and problem-solving skills.",
    ISBN = "9780201616224",
    ListPrice = 59,
    Price = 55,
    Price50 = 50,
    Price100 = 45,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("bb97d76f-fb7b-471b-a69c-fd90d0f8a70e"),
    Title = "Design Patterns",
    Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
    Description = "Elements of Reusable Object-Oriented Software detailing classic design patterns.",
    ISBN = "9780201633610",
    ListPrice = 69,
    Price = 65,
    Price50 = 60,
    Price100 = 55,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("c2459f93-3f73-45c9-ae86-65b3cd8a4b60"),
    Title = "Refactoring",
    Author = "Martin Fowler",
    Description = "Improving the design of existing code for better maintainability.",
    ISBN = "9780201485677",
    ListPrice = 64,
    Price = 60,
    Price50 = 55,
    Price100 = 50,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("d7e4d235-42a7-44ee-b2af-508e488c0bf2"),
    Title = "Head First Design Patterns",
    Author = "Eric Freeman, Elisabeth Robson",
    Description = "An approachable guide to software design patterns with engaging visuals.",
    ISBN = "9780596007126",
    ListPrice = 59,
    Price = 55,
    Price50 = 50,
    Price100 = 45,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("ed32c3ad-9b36-4c6b-8612-2b2ed4d8e17e"),
    Title = "You Don't Know JS",
    Author = "Kyle Simpson",
    Description = "A deep dive into the core mechanics of JavaScript and modern features.",
    ISBN = "9781491904244",
    ListPrice = 39,
    Price = 35,
    Price50 = 30,
    Price100 = 25,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("fa8dcdb8-f4f8-4042-9011-56737a69b914"),
    Title = "Eloquent JavaScript",
    Author = "Marijn Haverbeke",
    Description = "A modern introduction to JavaScript, covering core programming concepts.",
    ISBN = "9781593279509",
    ListPrice = 49,
    Price = 45,
    Price50 = 40,
    Price100 = 35,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("bb3b0412-d68f-4a22-a12d-56cb8d6e7325"),
    Title = "Cracking the Coding Interview",
    Author = "Gayle Laakmann McDowell",
    Description = "150 programming interview questions and solutions to prepare for technical interviews.",
    ISBN = "9780984782857",
    ListPrice = 69,
    Price = 65,
    Price50 = 60,
    Price100 = 55,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("97f70eeb-82a1-4c91-9f92-8a07bbdb33e3"),
    Title = "Introduction to Algorithms",
    Author = "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein",
    Description = "Comprehensive guide on algorithms for computer science students and professionals.",
    ISBN = "9780262033848",
    ListPrice = 89,
    Price = 85,
    Price50 = 80,
    Price100 = 75,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("3ec7e0a2-9c2d-4e45-8eb5-60b251e64523"),
    Title = "Code Complete",
    Author = "Steve McConnell",
    Description = "A practical handbook of software construction focusing on best coding practices.",
    ISBN = "9780735619678",
    ListPrice = 59,
    Price = 55,
    Price50 = 50,
    Price100 = 45,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("e4534f70-2a4a-4c21-919e-cfd1d6176e75"),
    Title = "Working Effectively with Legacy Code",
    Author = "Michael Feathers",
    Description = "Techniques to improve and refactor legacy codebases effectively.",
    ISBN = "9780131177055",
    ListPrice = 59,
    Price = 55,
    Price50 = 50,
    Price100 = 45,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("89be1842-d30a-4010-9d53-bfdb6b892814"),
    Title = "The Art of Computer Programming",
    Author = "Donald E. Knuth",
    Description = "A classic series covering algorithms and programming techniques.",
    ISBN = "9780201896831",
    ListPrice = 199,
    Price = 190,
    Price50 = 185,
    Price100 = 180,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("9e25e49f-5a3d-4d21-8b2b-711b70e413f8"),
    Title = "Introduction to the Theory of Computation",
    Author = "Michael Sipser",
    Description = "A theoretical approach to computation and algorithms.",
    ISBN = "9781133187790",
    ListPrice = 79,
    Price = 75,
    Price50 = 70,
    Price100 = 65,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("244b014e-5412-4de0-8f1e-f7e23c6b0cc3"),
    Title = "JavaScript: The Good Parts",
    Author = "Douglas Crockford",
    Description = "A concise guide to JavaScript's best features and practices.",
    ISBN = "9780596517748",
    ListPrice = 29,
    Price = 25,
    Price50 = 20,
    Price100 = 15,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("0a8bbf34-5827-4f88-9b2e-34e75f738d2f"),
    Title = "Domain-Driven Design",
    Author = "Eric Evans",
    Description = "Addressing complexity in software development through domain-driven design.",
    ISBN = "9780321125217",
    ListPrice = 69,
    Price = 65,
    Price50 = 60,
    Price100 = 55,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("47f2b9f2-98b8-4b50-b3b1-53d6db6ccdd2"),
    Title = "Python Crash Course",
    Author = "Eric Matthes",
    Description = "A hands-on, project-based introduction to Python programming.",
    ISBN = "9781593279288",
    ListPrice = 44,
    Price = 40,
    Price50 = 35,
    Price100 = 30,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("a15cb537-c97e-4c2e-bf10-159d7b3a191d"),
    Title = "C# in Depth",
    Author = "Jon Skeet",
    Description = "A comprehensive guide to mastering C# features and techniques.",
    ISBN = "9781617294532",
    ListPrice = 59,
    Price = 55,
    Price50 = 50,
    Price100 = 45,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("84d3d527-7052-4e27-8713-b1d7314c2f19"),
    Title = "Effective Java",
    Author = "Joshua Bloch",
    Description = "Best practices and design principles for Java programming.",
    ISBN = "9780134685991",
    ListPrice = 59,
    Price = 55,
    Price50 = 50,
    Price100 = 45,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("e5b4a63a-366e-47a3-8ae4-0d3171c455e3"),
    Title = "Deep Learning",
    Author = "Ian Goodfellow, Yoshua Bengio, Aaron Courville",
    Description = "A comprehensive introduction to deep learning concepts and techniques.",
    ISBN = "9780262035613",
    ListPrice = 89,
    Price = 85,
    Price50 = 80,
    Price100 = 75,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("71aebec8-5a88-4c6e-a892-39ad84662d6c"),
    Title = "Artificial Intelligence: A Modern Approach",
    Author = "Stuart Russell, Peter Norvig",
    Description = "A comprehensive overview of AI principles and techniques.",
    ISBN = "9780136042594",
    ListPrice = 99,
    Price = 95,
    Price50 = 90,
    Price100 = 85,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("5c2924a8-9051-4760-bc29-9ecbcf16d1f7"),
    Title = "Kubernetes Up & Running",
    Author = "Kelsey Hightower, Brendan Burns, Joe Beda",
    Description = "Dive into Kubernetes concepts and deploy containerized applications.",
    ISBN = "9781491935675",
    ListPrice = 59,
    Price = 55,
    Price50 = 50,
    Price100 = 45,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("6f34a8de-d194-42e7-9462-67ea5fd8577e"),
    Title = "Site Reliability Engineering",
    Author = "Niall Richard Murphy, Betsy Beyer, Chris Jones, Jennifer Petoff",
    Description = "Insights into Google's approach to reliability and operational excellence.",
    ISBN = "9781491929124",
    ListPrice = 79,
    Price = 75,
    Price50 = 70,
    Price100 = 65,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("c1d5a61b-d9e2-44f3-8ed1-26851e5fc0b8"),
    Title = "Agile Estimating and Planning",
    Author = "Mike Cohn",
    Description = "Guidance on estimating and planning in agile software development.",
    ISBN = "9780131479418",
    ListPrice = 49,
    Price = 45,
    Price50 = 40,
    Price100 = 35,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("c8b6c11f-7b5d-4051-9c2a-e0b07c2fc47e"),
    Title = "Test-Driven Development by Example",
    Author = "Kent Beck",
    Description = "Introduction to test-driven development with practical examples.",
    ISBN = "9780321146533",
    ListPrice = 39,
    Price = 35,
    Price50 = 30,
    Price100 = 25,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("5b462e1e-d7c7-47d6-a9b6-fd343cfdb8d4"),
    Title = "Clean Architecture",
    Author = "Robert C. Martin",
    Description = "A guide to software structure and architecture principles.",
    ISBN = "9780134494166",
    ListPrice = 59,
    Price = 55,
    Price50 = 50,
    Price100 = 45,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("89d06b93-f835-4d58-8170-8fbe3156ec27"),
    Title = "Continuous Delivery",
    Author = "Jez Humble, David Farley",
    Description = "Reliable software releases through build, test, and deployment automation.",
    ISBN = "9780321601919",
    ListPrice = 59,
    Price = 55,
    Price50 = 50,
    Price100 = 45,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("62c8a7da-5f41-4ef2-8049-06415357e204"),
    Title = "Effective Python",
    Author = "Brett Slatkin",
    Description = "59 specific ways to improve Python programs.",
    ISBN = "9780134034287",
    ListPrice = 44,
    Price = 40,
    Price50 = 35,
    Price100 = 30,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("af3df834-5d0a-4629-a1b4-57dfabdd43cd"),
    Title = "The Phoenix Project",
    Author = "Gene Kim, Kevin Behr, George Spafford",
    Description = "A novel about IT, DevOps, and helping businesses win.",
    ISBN = "9780988262591",
    ListPrice = 49,
    Price = 45,
    Price50 = 40,
    Price100 = 35,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("4c40c99c-e9e4-4c8b-bb8d-dfa19b9d7cb2"),
    Title = "Learning React",
    Author = "Alex Banks, Eve Porcello",
    Description = "A hands-on guide to building web applications using React.",
    ISBN = "9781491954621",
    ListPrice = 44,
    Price = 40,
    Price50 = 35,
    Price100 = 30,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("2b92dc6e-1dc7-4aaf-b21c-6825dbadfc2f"),
    Title = "Docker Deep Dive",
    Author = "Nigel Poulton",
    Description = "Learn Docker in-depth and practical use cases.",
    ISBN = "9781521822807",
    ListPrice = 39,
    Price = 35,
    Price50 = 30,
    Price100 = 25,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("7d5456f5-4b0d-4ba6-80ee-b14d8d6cf3e8"),
    Title = "Ansible for DevOps",
    Author = "Jeff Geerling",
    Description = "Simple IT automation through Ansible.",
    ISBN = "9780989551335",
    ListPrice = 39,
    Price = 35,
    Price50 = 30,
    Price100 = 25,
    ImageUrl = "",
},
new Product
{
    Id = Guid.Parse("12b53bfb-46fa-4c03-bd36-f299fc94eb5e"),
    Title = "Programming Pearls",
    Author = "Jon Bentley",
    Description = "Insights into coding and problem-solving techniques for software developers.",
    ISBN = "9780201657883",
    ListPrice = 49,
    Price = 45,
    Price50 = 40,
    Price100 = 35,
    ImageUrl = "",
});
        }
    }
}
