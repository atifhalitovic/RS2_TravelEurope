using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class inicijalna : Migration
    {
        protected override void Up(MigrationBuilder MigrationBuilder)
        {
            MigrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaId);
                });

            MigrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaId);
                });

            MigrationBuilder.CreateTable(
                name: "MarkaVozila",
                columns: table => new
                {
                    MarkaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkaVozila", x => x.MarkaId);
                });

            MigrationBuilder.CreateTable(
                name: "NacinPlacanja",
                columns: table => new
                {
                    NacinPlacanjaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NacinPlacanja", x => x.NacinPlacanjaId);
                });

            MigrationBuilder.CreateTable(
                name: "StatusVozaca",
                columns: table => new
                {
                    StatusVozacaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dostupan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusVozaca", x => x.StatusVozacaId);
                });

            MigrationBuilder.CreateTable(
                name: "StatusVozila",
                columns: table => new
                {
                    StatusVozilaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true),
                    Ispravnost = table.Column<bool>(nullable: false),
                    Rezervisano = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusVozila", x => x.StatusVozilaId);
                });

            MigrationBuilder.CreateTable(
                name: "StraniJezik",
                columns: table => new
                {
                    StraniJezikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StraniJezik", x => x.StraniJezikId);
                });

            MigrationBuilder.CreateTable(
                name: "TipVozila",
                columns: table => new
                {
                    TipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipVozila", x => x.TipId);
                });

            MigrationBuilder.CreateTable(
                name: "VrstaGoriva",
                columns: table => new
                {
                    GorivoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaGoriva", x => x.GorivoId);
                });

            MigrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradId);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    LokacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.LokacijaId);
                    table.ForeignKey(
                        name: "FK_Lokacija_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "Vozac",
                columns: table => new
                {
                    VozacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    BrVozackeDozvole = table.Column<string>(nullable: true),
                    StatusVozacaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozac", x => x.VozacId);
                    table.ForeignKey(
                        name: "FK_Vozac_StatusVozaca_StatusVozacaId",
                        column: x => x.StatusVozacaId,
                        principalTable: "StatusVozaca",
                        principalColumn: "StatusVozacaId",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "TuristickiVodic",
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
                    table.PrimaryKey("PK_TuristickiVodic", x => x.TuristickiVodicId);
                    table.ForeignKey(
                        name: "FK_TuristickiVodic_StraniJezik_StraniJezikId",
                        column: x => x.StraniJezikId,
                        principalTable: "StraniJezik",
                        principalColumn: "StraniJezikId",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    VoziloId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    TipVozilaId = table.Column<int>(nullable: false),
                    GodinaProizvodnje = table.Column<int>(nullable: false),
                    MarkaVozilaId = table.Column<int>(nullable: false),
                    StatusVozilaId = table.Column<int>(nullable: false),
                    VrstaGorivaId = table.Column<int>(nullable: false),
                    BrojSjedista = table.Column<int>(nullable: false),
                    Boja = table.Column<string>(nullable: true),
                    BrojVrata = table.Column<int>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.VoziloId);
                    table.ForeignKey(
                        name: "FK_Vozilo_MarkaVozila_MarkaVozilaId",
                        column: x => x.MarkaVozilaId,
                        principalTable: "MarkaVozila",
                        principalColumn: "MarkaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_StatusVozila_StatusVozilaId",
                        column: x => x.StatusVozilaId,
                        principalTable: "StatusVozila",
                        principalColumn: "StatusVozilaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_TipVozila_TipVozilaId",
                        column: x => x.TipVozilaId,
                        principalTable: "TipVozila",
                        principalColumn: "TipId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_VrstaGoriva_VrstaGorivaId",
                        column: x => x.VrstaGorivaId,
                        principalTable: "VrstaGoriva",
                        principalColumn: "GorivoId",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    GradId = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    JMBG = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korisnici_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "TuristRuta",
                columns: table => new
                {
                    TuristRutaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    TuristickiVodicId = table.Column<int>(nullable: false),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuristRuta", x => x.TuristRutaId);
                    table.ForeignKey(
                        name: "FK_TuristRuta_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TuristRuta_TuristickiVodic_TuristickiVodicId",
                        column: x => x.TuristickiVodicId,
                        principalTable: "TuristickiVodic",
                        principalColumn: "TuristickiVodicId",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdministratorId = table.Column<int>(nullable: false),
                    IzjavaZastitaPodataka = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdministratorId);
                    table.ForeignKey(
                        name: "FK_Administrator_Korisnici_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "Klijent",
                columns: table => new
                {
                    KlijentId = table.Column<int>(nullable: false),
                    BrojPasosa = table.Column<string>(nullable: true),
                    BrVozackeDozvole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijent", x => x.KlijentId);
                    table.ForeignKey(
                        name: "FK_Klijent_Korisnici_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "Radnik",
                columns: table => new
                {
                    RadnikId = table.Column<int>(nullable: false),
                    Pozicija = table.Column<string>(nullable: true),
                    GodineStaza = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnik", x => x.RadnikId);
                    table.ForeignKey(
                        name: "FK_Radnik_Korisnici_RadnikId",
                        column: x => x.RadnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
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
                        name: "FK_RuteSlike_TuristRuta_TuristRutaId",
                        column: x => x.TuristRutaId,
                        principalTable: "TuristRuta",
                        principalColumn: "TuristRutaId",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumPreuzimanja = table.Column<DateTime>(nullable: false),
                    DatumVracanja = table.Column<DateTime>(nullable: false),
                    CijenaUslugePoDanu = table.Column<double>(nullable: false),
                    CijenaOsiguranja = table.Column<double>(nullable: false),
                    KlijentId = table.Column<int>(nullable: false),
                    RadnikId = table.Column<int>(nullable: false),
                    VozacId = table.Column<int>(nullable: true),
                    VoziloId = table.Column<int>(nullable: true),
                    TuristRutaId = table.Column<int>(nullable: true),
                    RacunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Klijent_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijent",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Radnik_RadnikId",
                        column: x => x.RadnikId,
                        principalTable: "Radnik",
                        principalColumn: "RadnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Rezervacija_TuristRuta_TuristRutaId",
                        column: x => x.TuristRutaId,
                        principalTable: "TuristRuta",
                        principalColumn: "TuristRutaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Vozac_VozacId",
                        column: x => x.VozacId,
                        principalTable: "Vozac",
                        principalColumn: "VozacId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Vozilo_VoziloId",
                        column: x => x.VoziloId,
                        principalTable: "Vozilo",
                        principalColumn: "VoziloId",
                        onDelete: ReferentialAction.Restrict);
                });

            MigrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    RacunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RezervacijaId = table.Column<int>(nullable: false),
                    DatumIzdavanja = table.Column<DateTime>(nullable: false),
                    TrajanjeRentanjaDani = table.Column<int>(nullable: false),
                    NacinPlacanjaId = table.Column<int>(nullable: false),
                    CijenaUslugeSaPDVom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.RacunId);
                    table.ForeignKey(
                        name: "FK_Racun_NacinPlacanja_NacinPlacanjaId",
                        column: x => x.NacinPlacanjaId,
                        principalTable: "NacinPlacanja",
                        principalColumn: "NacinPlacanjaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Racun_Rezervacija_RezervacijaId",
                        column: x => x.RezervacijaId,
                        principalTable: "Rezervacija",
                        principalColumn: "RezervacijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Korisnici_GradId",
                table: "Korisnici",
                column: "GradId");

            MigrationBuilder.CreateIndex(
                name: "IX_Lokacija_DrzavaId",
                table: "Lokacija",
                column: "DrzavaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Racun_NacinPlacanjaId",
                table: "Racun",
                column: "NacinPlacanjaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Racun_RezervacijaId",
                table: "Racun",
                column: "RezervacijaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KlijentId",
                table: "Rezervacija",
                column: "KlijentId");

            MigrationBuilder.CreateIndex(
                name: "IX_Rezervacija_RacunId",
                table: "Rezervacija",
                column: "RacunId");

            MigrationBuilder.CreateIndex(
                name: "IX_Rezervacija_RadnikId",
                table: "Rezervacija",
                column: "RadnikId");

            MigrationBuilder.CreateIndex(
                name: "IX_Rezervacija_TuristRutaId",
                table: "Rezervacija",
                column: "TuristRutaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Rezervacija_VozacId",
                table: "Rezervacija",
                column: "VozacId");

            MigrationBuilder.CreateIndex(
                name: "IX_Rezervacija_VoziloId",
                table: "Rezervacija",
                column: "VoziloId");

            MigrationBuilder.CreateIndex(
                name: "IX_RuteSlike_TuristRutaId",
                table: "RuteSlike",
                column: "TuristRutaId");

            MigrationBuilder.CreateIndex(
                name: "IX_TuristickiVodic_StraniJezikId",
                table: "TuristickiVodic",
                column: "StraniJezikId");

            MigrationBuilder.CreateIndex(
                name: "IX_TuristRuta_DrzavaId",
                table: "TuristRuta",
                column: "DrzavaId");

            MigrationBuilder.CreateIndex(
                name: "IX_TuristRuta_TuristickiVodicId",
                table: "TuristRuta",
                column: "TuristickiVodicId");

            MigrationBuilder.CreateIndex(
                name: "IX_Vozac_StatusVozacaId",
                table: "Vozac",
                column: "StatusVozacaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Vozilo_MarkaVozilaId",
                table: "Vozilo",
                column: "MarkaVozilaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Vozilo_StatusVozilaId",
                table: "Vozilo",
                column: "StatusVozilaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Vozilo_TipVozilaId",
                table: "Vozilo",
                column: "TipVozilaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Vozilo_VrstaGorivaId",
                table: "Vozilo",
                column: "VrstaGorivaId");

            MigrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Racun_RacunId",
                table: "Rezervacija",
                column: "RacunId",
                principalTable: "Racun",
                principalColumn: "RacunId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder MigrationBuilder)
        {
            MigrationBuilder.DropForeignKey(
                name: "FK_Klijent_Korisnici_KlijentId",
                table: "Klijent");

            MigrationBuilder.DropForeignKey(
                name: "FK_Radnik_Korisnici_RadnikId",
                table: "Radnik");

            MigrationBuilder.DropForeignKey(
                name: "FK_TuristRuta_Drzava_DrzavaId",
                table: "TuristRuta");

            MigrationBuilder.DropForeignKey(
                name: "FK_Racun_NacinPlacanja_NacinPlacanjaId",
                table: "Racun");

            MigrationBuilder.DropForeignKey(
                name: "FK_Racun_Rezervacija_RezervacijaId",
                table: "Racun");

            MigrationBuilder.DropTable(
                name: "Administrator");

            MigrationBuilder.DropTable(
                name: "Kategorija");

            MigrationBuilder.DropTable(
                name: "Lokacija");

            MigrationBuilder.DropTable(
                name: "RuteSlike");

            MigrationBuilder.DropTable(
                name: "Korisnici");

            MigrationBuilder.DropTable(
                name: "Grad");

            MigrationBuilder.DropTable(
                name: "Drzava");

            MigrationBuilder.DropTable(
                name: "NacinPlacanja");

            MigrationBuilder.DropTable(
                name: "Rezervacija");

            MigrationBuilder.DropTable(
                name: "Klijent");

            MigrationBuilder.DropTable(
                name: "Racun");

            MigrationBuilder.DropTable(
                name: "Radnik");

            MigrationBuilder.DropTable(
                name: "TuristRuta");

            MigrationBuilder.DropTable(
                name: "Vozac");

            MigrationBuilder.DropTable(
                name: "Vozilo");

            MigrationBuilder.DropTable(
                name: "TuristickiVodic");

            MigrationBuilder.DropTable(
                name: "StatusVozaca");

            MigrationBuilder.DropTable(
                name: "MarkaVozila");

            MigrationBuilder.DropTable(
                name: "StatusVozila");

            MigrationBuilder.DropTable(
                name: "TipVozila");

            MigrationBuilder.DropTable(
                name: "VrstaGoriva");

            MigrationBuilder.DropTable(
                name: "StraniJezik");
        }
    }
}
