using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_BJSS5.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Food = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Movie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Name", "PublishYear", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Louisa May Alcott", "Bidhatri", 1868, "Simon & Schuster", "Little Women" },
                    { 2, "Satoshi Yagisawa", "Jasmine", 2023, "Harper Perennial", "Days at the Morisaki Bookshop" },
                    { 3, "Victor Hugo", "Sage", 1862, "A. Lacroix, Verboeckhoven & Cie.", "Les Miserables" },
                    { 4, "Noel Streatfeild", "Sydney", 1936, "J. M. Dent & Sons", "Ballet Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "Id", "Color", "Drink", "Food", "Movie", "Name" },
                values: new object[,]
                {
                    { 1, "Purple", "Bubble Tea", "Cheesecake", "Pride and Prejudice", "Bidhatri" },
                    { 2, "Green", "Matcha", "Sushi", "The Meg 2", "Jasmine" },
                    { 3, "Blue", "Gold Peak Tea", "Mashed Potatoes", "First Blood", "Sage" },
                    { 4, "grey", "Water", "Cucumber", "Z-O-M-B-I-E-S", "Sydney" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
