using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace john_moreau_C6_FAQs_app.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "Id", "Answer", "Category", "Question", "Topic" },
                values: new object[,]
                {
                    { 1, "A CSS framework for creating responsive web apps for multiple screen sizes.", "General", "What is Bootstrap?", "Bootstrap" },
                    { 2, "A general purpose object oriented language that uses a concise, Java-like syntax.", "General", "What is C#?", "C#" },
                    { 3, "A general purpose scripting language that executes in a web browser.", "General", "What is JavaScript?", "JavaScript" },
                    { 4, "In 2011.", "History", "When was Bootstrap first released?", "Bootstrap" },
                    { 5, "In 2002.", "History", "When was C# first released?", "C#" },
                    { 6, "In 1995.", "History", "When was JavaScript first released?", "JavaScript" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");
        }
    }
}
