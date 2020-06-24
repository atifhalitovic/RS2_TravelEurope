using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class OcjeneReset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ocjene");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumOcjene = table.Column<DateTime>(nullable: false),
                    Komentar = table.Column<string>(nullable: true),
                    KorisnikId = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    RezervacijaId = table.Column<int>(nullable: false),
                    TuristRuteTuristRutaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_Ocjene_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocjene_Rezervacije_RezervacijaId",
                        column: x => x.RezervacijaId,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocjene_TuristRute_TuristRuteTuristRutaId",
                        column: x => x.TuristRuteTuristRutaId,
                        principalTable: "TuristRute",
                        principalColumn: "TuristRutaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KorisnikId",
                table: "Ocjene",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_RezervacijaId",
                table: "Ocjene",
                column: "RezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_TuristRuteTuristRutaId",
                table: "Ocjene",
                column: "TuristRuteTuristRutaId");
        }
    }
}
