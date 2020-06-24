using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class RecenzijeOcjeneChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_TuristRute_TuristRutaId",
                table: "Ocjene");

            migrationBuilder.DropTable(
                name: "KorisniciFriends");

            migrationBuilder.DropTable(
                name: "Recenzije");

            migrationBuilder.RenameColumn(
                name: "TuristRutaId",
                table: "Ocjene",
                newName: "RezervacijaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ocjene_TuristRutaId",
                table: "Ocjene",
                newName: "IX_Ocjene_RezervacijaId");

            migrationBuilder.AddColumn<int>(
                name: "TuristRuteTuristRutaId",
                table: "Ocjene",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_TuristRuteTuristRutaId",
                table: "Ocjene",
                column: "TuristRuteTuristRutaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_Rezervacije_RezervacijaId",
                table: "Ocjene",
                column: "RezervacijaId",
                principalTable: "Rezervacije",
                principalColumn: "RezervacijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_TuristRute_TuristRuteTuristRutaId",
                table: "Ocjene",
                column: "TuristRuteTuristRutaId",
                principalTable: "TuristRute",
                principalColumn: "TuristRutaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_Rezervacije_RezervacijaId",
                table: "Ocjene");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_TuristRute_TuristRuteTuristRutaId",
                table: "Ocjene");

            migrationBuilder.DropIndex(
                name: "IX_Ocjene_TuristRuteTuristRutaId",
                table: "Ocjene");

            migrationBuilder.DropColumn(
                name: "TuristRuteTuristRutaId",
                table: "Ocjene");

            migrationBuilder.RenameColumn(
                name: "RezervacijaId",
                table: "Ocjene",
                newName: "TuristRutaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ocjene_RezervacijaId",
                table: "Ocjene",
                newName: "IX_Ocjene_TuristRutaId");

            migrationBuilder.CreateTable(
                name: "KorisniciFriends",
                columns: table => new
                {
                    KorisniciFriendsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FriendId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciFriends", x => x.KorisniciFriendsId);
                    table.ForeignKey(
                        name: "FK_KorisniciFriends_Korisnici_FriendId",
                        column: x => x.FriendId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisniciFriends_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recenzije",
                columns: table => new
                {
                    RecenzijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumRecenzije = table.Column<DateTime>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    Sadrzaj = table.Column<string>(nullable: true),
                    TuristRutaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzije", x => x.RecenzijaId);
                    table.ForeignKey(
                        name: "FK_Recenzije_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recenzije_TuristRute_TuristRutaId",
                        column: x => x.TuristRutaId,
                        principalTable: "TuristRute",
                        principalColumn: "TuristRutaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciFriends_FriendId",
                table: "KorisniciFriends",
                column: "FriendId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciFriends_KorisnikId",
                table: "KorisniciFriends",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzije_KorisnikId",
                table: "Recenzije",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzije_TuristRutaId",
                table: "Recenzije",
                column: "TuristRutaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_TuristRute_TuristRutaId",
                table: "Ocjene",
                column: "TuristRutaId",
                principalTable: "TuristRute",
                principalColumn: "TuristRutaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
