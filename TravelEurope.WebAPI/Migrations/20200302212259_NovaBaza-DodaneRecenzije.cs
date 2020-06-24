using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class NovaBazaDodaneRecenzije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaId);
                });

            migrationBuilder.CreateTable(
                name: "Kategorije",
                columns: table => new
                {
                    KategorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorije", x => x.KategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "StraniJezici",
                columns: table => new
                {
                    StraniJezikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StraniJezici", x => x.StraniJezikId);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradId);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lokacije",
                columns: table => new
                {
                    LokacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacije", x => x.LokacijaId);
                    table.ForeignKey(
                        name: "FK_Lokacije_Drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuristickiVodici",
                columns: table => new
                {
                    TuristickiVodicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    StraniJezikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuristickiVodici", x => x.TuristickiVodicId);
                    table.ForeignKey(
                        name: "FK_TuristickiVodici_StraniJezici_StraniJezikId",
                        column: x => x.StraniJezikId,
                        principalTable: "StraniJezici",
                        principalColumn: "StraniJezikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisniciId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    GradId = table.Column<int>(nullable: false),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    ZadnjaAktivnost = table.Column<DateTime>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    UlogaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisniciId);
                    table.ForeignKey(
                        name: "FK_Korisnici_Gradovi_GradId",
                        column: x => x.GradId,
                        principalTable: "Gradovi",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korisnici_Uloge_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuristRute",
                columns: table => new
                {
                    TuristRutaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KategorijaId = table.Column<int>(nullable: false),
                    LokacijaId = table.Column<int>(nullable: false),
                    TuristickiVodicId = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    DatumPutovanja = table.Column<DateTime>(nullable: false),
                    TrajanjePutovanja = table.Column<int>(nullable: false),
                    CijenaPaketa = table.Column<decimal>(nullable: false),
                    CijenaOsiguranja = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuristRute", x => x.TuristRutaId);
                    table.ForeignKey(
                        name: "FK_TuristRute_Kategorije_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TuristRute_Lokacije_LokacijaId",
                        column: x => x.LokacijaId,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TuristRute_TuristickiVodici_TuristickiVodicId",
                        column: x => x.TuristickiVodicId,
                        principalTable: "TuristickiVodici",
                        principalColumn: "TuristickiVodicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciFriends",
                columns: table => new
                {
                    KorisniciFriendsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikId = table.Column<int>(nullable: false),
                    FriendId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciFriends", x => x.KorisniciFriendsId);
                    table.ForeignKey(
                        name: "FK_KorisniciFriends_Korisnici_FriendId",
                        column: x => x.FriendId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_KorisniciFriends_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Poruke",
                columns: table => new
                {
                    PorukaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sadrzaj = table.Column<string>(nullable: true),
                    PrimalacId = table.Column<int>(nullable: false),
                    PosiljalacId = table.Column<int>(nullable: false),
                    DatumVrijeme = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruke", x => x.PorukaId);
                    table.ForeignKey(
                        name: "FK_Poruke_Korisnici_PosiljalacId",
                        column: x => x.PosiljalacId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Poruke_Korisnici_PrimalacId",
                        column: x => x.PrimalacId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pretplate",
                columns: table => new
                {
                    PretplataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikId = table.Column<int>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pretplate", x => x.PretplataId);
                    table.ForeignKey(
                        name: "FK_Pretplate_Kategorije_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pretplate_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikId = table.Column<int>(nullable: false),
                    TuristRutaId = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    DatumOcjene = table.Column<DateTime>(nullable: false),
                    Komentar = table.Column<string>(nullable: true)
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
                        name: "FK_Ocjene_TuristRute_TuristRutaId",
                        column: x => x.TuristRutaId,
                        principalTable: "TuristRute",
                        principalColumn: "TuristRutaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recenzije",
                columns: table => new
                {
                    RecenzijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikId = table.Column<int>(nullable: false),
                    TuristRutaId = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    DatumRecenzije = table.Column<DateTime>(nullable: false),
                    Sadrzaj = table.Column<string>(nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumRezervacije = table.Column<DateTime>(nullable: false),
                    TuristRutaId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_TuristRute_TuristRutaId",
                        column: x => x.TuristRutaId,
                        principalTable: "TuristRute",
                        principalColumn: "TuristRutaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RuteSlike",
                columns: table => new
                {
                    RuteSlikeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TuristRutaId = table.Column<int>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumb = table.Column<byte[]>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuteSlike", x => x.RuteSlikeId);
                    table.ForeignKey(
                        name: "FK_RuteSlike_TuristRute_TuristRutaId",
                        column: x => x.TuristRutaId,
                        principalTable: "TuristRute",
                        principalColumn: "TuristRutaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaId",
                table: "Gradovi",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_GradId",
                table: "Korisnici",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_UlogaId",
                table: "Korisnici",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciFriends_FriendId",
                table: "KorisniciFriends",
                column: "FriendId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciFriends_KorisnikId",
                table: "KorisniciFriends",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Lokacije_DrzavaId",
                table: "Lokacije",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KorisnikId",
                table: "Ocjene",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_TuristRutaId",
                table: "Ocjene",
                column: "TuristRutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_PosiljalacId",
                table: "Poruke",
                column: "PosiljalacId");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_PrimalacId",
                table: "Poruke",
                column: "PrimalacId");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplate_KategorijaId",
                table: "Pretplate",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplate_KorisnikId",
                table: "Pretplate",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzije_KorisnikId",
                table: "Recenzije",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzije_TuristRutaId",
                table: "Recenzije",
                column: "TuristRutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KorisnikId",
                table: "Rezervacije",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_TuristRutaId",
                table: "Rezervacije",
                column: "TuristRutaId");

            migrationBuilder.CreateIndex(
                name: "IX_RuteSlike_TuristRutaId",
                table: "RuteSlike",
                column: "TuristRutaId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristickiVodici_StraniJezikId",
                table: "TuristickiVodici",
                column: "StraniJezikId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristRute_KategorijaId",
                table: "TuristRute",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristRute_LokacijaId",
                table: "TuristRute",
                column: "LokacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristRute_TuristickiVodicId",
                table: "TuristRute",
                column: "TuristickiVodicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciFriends");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "Poruke");

            migrationBuilder.DropTable(
                name: "Pretplate");

            migrationBuilder.DropTable(
                name: "Recenzije");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "RuteSlike");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "TuristRute");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Kategorije");

            migrationBuilder.DropTable(
                name: "Lokacije");

            migrationBuilder.DropTable(
                name: "TuristickiVodici");

            migrationBuilder.DropTable(
                name: "Drzave");

            migrationBuilder.DropTable(
                name: "StraniJezici");
        }
    }
}
