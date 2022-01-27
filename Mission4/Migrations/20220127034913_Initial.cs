using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieResponses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieResponses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "MovieResponses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Comedy", "Akiva Shaffer", false, "", "My name is Rod", "PG-13", "Hot Rod", 2007 });

            migrationBuilder.InsertData(
                table: "MovieResponses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Sci-Fi", "Richard Marquand", true, "Brett", "Hit it Chewy!", "PG", "Star Wars: Return of the Jedi", 1983 });

            migrationBuilder.InsertData(
                table: "MovieResponses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Family/Adventure", "Andrew Stanton", false, "Conner", "Wallaby Way Sydney", "G", "Finding Nemo", 2003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieResponses");
        }
    }
}
