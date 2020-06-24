using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class RemoveKategorijaRute : Migration
    {
        protected override void Up(MigrationBuilder MigrationBuilder)
        {
            MigrationBuilder.DropTable(
                name: "Kategorija");
        }

        protected override void Down(MigrationBuilder MigrationBuilder)
        {
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
        }
    }
}
