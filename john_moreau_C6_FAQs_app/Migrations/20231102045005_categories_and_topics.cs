using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace john_moreau_C6_FAQs_app.Migrations
{
    /// <inheritdoc />
    public partial class categories_and_topics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "Topic",
                table: "FAQs");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "FAQs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TopicId",
                table: "FAQs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "gen", "General" },
                    { "hist", "History" }
                });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "TopicId" },
                values: new object[] { "gen", "bs" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "TopicId" },
                values: new object[] { "gen", "cs" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "TopicId" },
                values: new object[] { "gen", "js" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "TopicId" },
                values: new object[] { "hist", "bs" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "TopicId" },
                values: new object[] { "hist", "cs" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "TopicId" },
                values: new object[] { "hist", "js" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "bs", "Bootstrap" },
                    { "cs", "C#" },
                    { "js", "JavaScript" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryId",
                table: "FAQs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicId",
                table: "FAQs",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_FAQs_Categories_CategoryId",
                table: "FAQs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FAQs_Topics_TopicId",
                table: "FAQs",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FAQs_Categories_CategoryId",
                table: "FAQs");

            migrationBuilder.DropForeignKey(
                name: "FK_FAQs_Topics_TopicId",
                table: "FAQs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_FAQs_CategoryId",
                table: "FAQs");

            migrationBuilder.DropIndex(
                name: "IX_FAQs_TopicId",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "FAQs");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "FAQs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Topic",
                table: "FAQs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Topic" },
                values: new object[] { "General", "Bootstrap" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Topic" },
                values: new object[] { "General", "C#" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Topic" },
                values: new object[] { "General", "JavaScript" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Topic" },
                values: new object[] { "History", "Bootstrap" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Topic" },
                values: new object[] { "History", "C#" });

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Topic" },
                values: new object[] { "History", "JavaScript" });
        }
    }
}
