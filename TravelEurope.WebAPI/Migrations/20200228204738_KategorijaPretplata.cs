using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class KategorijaPretplata : Migration
    {
        protected override void Up(MigrationBuilder MigrationBuilder)
        {
            MigrationBuilder.CreateTable(
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

            MigrationBuilder.CreateTable(
                name: "ItemKategorije",
                columns: table => new
                {
                    ItemKategorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TuristRutaId = table.Column<int>(nullable: true),
                    VoziloId = table.Column<int>(nullable: true),
                    VozacId = table.Column<int>(nullable: true),
                    KategorijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemKategorije", x => x.ItemKategorijaId);
                    table.ForeignKey(
                        name: "FK_ItemKategorije_Kategorije_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemKategorije_TuristRuta_TuristRutaId",
                        column: x => x.TuristRutaId,
                        principalTable: "TuristRuta",
                        principalColumn: "TuristRutaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemKategorije_Vozac_VozacId",
                        column: x => x.VozacId,
                        principalTable: "Vozac",
                        principalColumn: "VozacId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemKategorije_Vozilo_VoziloId",
                        column: x => x.VoziloId,
                        principalTable: "Vozilo",
                        principalColumn: "VoziloId",
                        onDelete: ReferentialAction.Restrict);
                });

            MigrationBuilder.CreateTable(
                name: "Pretplata",
                columns: table => new
                {
                    PretplataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikId = table.Column<int>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pretplata", x => x.PretplataId);
                    table.ForeignKey(
                        name: "FK_Pretplata_Kategorije_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pretplata_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            MigrationBuilder.CreateIndex(
                name: "IX_ItemKategorije_KategorijaId",
                table: "ItemKategorije",
                column: "KategorijaId");

            MigrationBuilder.CreateIndex(
                name: "IX_ItemKategorije_TuristRutaId",
                table: "ItemKategorije",
                column: "TuristRutaId");

            MigrationBuilder.CreateIndex(
                name: "IX_ItemKategorije_VozacId",
                table: "ItemKategorije",
                column: "VozacId");

            MigrationBuilder.CreateIndex(
                name: "IX_ItemKategorije_VoziloId",
                table: "ItemKategorije",
                column: "VoziloId");

            MigrationBuilder.CreateIndex(
                name: "IX_Pretplata_KategorijaId",
                table: "Pretplata",
                column: "KategorijaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Pretplata_KorisnikId",
                table: "Pretplata",
                column: "KorisnikId");
        }

        protected override void Down(MigrationBuilder MigrationBuilder)
        {
            MigrationBuilder.DropTable(
                name: "ItemKategorije");

            MigrationBuilder.DropTable(
                name: "Pretplata");

            MigrationBuilder.DropTable(
                name: "Kategorije");
        }
    }
}
