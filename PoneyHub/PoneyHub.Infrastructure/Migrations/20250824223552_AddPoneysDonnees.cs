using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PoneyHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPoneysDonnees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Poney",
                columns: new[] { "Id", "CategorieId", "Coefficient", "Description", "Nom", "Photo" },
                values: new object[,]
                {
                    { 1, 3, 1.0, "Aime quand y'a plein de couleur de partout", "Karim", "" },
                    { 2, 1, 1.0, "Aime se poser dans l'herbe, la brouter et prendre son temps", "Matthieu", "" },
                    { 3, 1, 1.0, "Préfère rester dans son coin mais prend des coups de folie par moment", "Valentin", "" },
                    { 4, 2, 25.0, "Adore quand ca danse et que ca se frotte", "Fabrice", "" },
                    { 5, 1, 1.0, "Deteste quand ça parle trop et préfere se focus sur l'action", "Sylvain", "" },
                    { 6, 1, 1.0, "Vieux poney qui a ses petites habitudes mais très gentil", "Elric", "" },
                    { 7, 1, 1.0, "Petit poney qui adore l'argent, et est parfait pour aller récolter les impots", "Kevin", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Poney",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Poney",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Poney",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Poney",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Poney",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Poney",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Poney",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
