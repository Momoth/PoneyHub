using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoneyHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPrestation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateHeureDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateHeureFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontantFacture = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PoneyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestation_Poney_PoneyId",
                        column: x => x.PoneyId,
                        principalTable: "Poney",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestation_PoneyId",
                table: "Prestation",
                column: "PoneyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestation");
        }
    }
}
