using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PoneyHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorieId",
                table: "Poney",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "Id", "Libelle" },
                values: new object[,]
                {
                    { 1, "Terrestre" },
                    { 2, "Licorne" },
                    { 3, "Pégase" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Poney_CategorieId",
                table: "Poney",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Poney_Categorie_CategorieId",
                table: "Poney",
                column: "CategorieId",
                principalTable: "Categorie",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poney_Categorie_CategorieId",
                table: "Poney");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropIndex(
                name: "IX_Poney_CategorieId",
                table: "Poney");

            migrationBuilder.DropColumn(
                name: "CategorieId",
                table: "Poney");
        }
    }
}
