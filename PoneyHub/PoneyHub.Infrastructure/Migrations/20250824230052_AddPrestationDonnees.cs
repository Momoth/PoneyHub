using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PoneyHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPrestationDonnees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Prestation",
                columns: new[] { "Id", "DateHeureDebut", "DateHeureFin", "MontantFacture", "PoneyId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 500m, 1 },
                    { 2, new DateTime(2025, 8, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 700m, 1 },
                    { 3, new DateTime(2025, 8, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 600m, 1 },
                    { 4, new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 500m, 2 },
                    { 5, new DateTime(2025, 8, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 700m, 2 },
                    { 6, new DateTime(2025, 8, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 700m, 3 },
                    { 7, new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 400m, 3 },
                    { 8, new DateTime(2025, 8, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 800m, 4 },
                    { 9, new DateTime(2025, 8, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 500m, 4 },
                    { 10, new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 500m, 5 },
                    { 11, new DateTime(2025, 8, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 700m, 6 },
                    { 12, new DateTime(2025, 8, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 700m, 6 },
                    { 13, new DateTime(2025, 8, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 400m, 6 },
                    { 14, new DateTime(2025, 8, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 800m, 7 },
                    { 15, new DateTime(2025, 8, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 500m, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Prestation",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
