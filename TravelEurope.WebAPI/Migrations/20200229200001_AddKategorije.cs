using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class AddKategorije : Migration
    {
        protected override void Up(MigrationBuilder MigrationBuilder)
        {
            MigrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "Vozilo",
                nullable: false,
                defaultValue: 0);

            MigrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "Vozac",
                nullable: false,
                defaultValue: 0);

            MigrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "TuristRuta",
                nullable: false,
                defaultValue: 0);

            MigrationBuilder.CreateIndex(
                name: "IX_Vozilo_KategorijaId",
                table: "Vozilo",
                column: "KategorijaId");

            MigrationBuilder.CreateIndex(
                name: "IX_Vozac_KategorijaId",
                table: "Vozac",
                column: "KategorijaId");

            MigrationBuilder.CreateIndex(
                name: "IX_TuristRuta_KategorijaId",
                table: "TuristRuta",
                column: "KategorijaId");

            MigrationBuilder.AddForeignKey(
                name: "FK_TuristRuta_Kategorije_KategorijaId",
                table: "TuristRuta",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);

            MigrationBuilder.AddForeignKey(
                name: "FK_Vozac_Kategorije_KategorijaId",
                table: "Vozac",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);

            MigrationBuilder.AddForeignKey(
                name: "FK_Vozilo_Kategorije_KategorijaId",
                table: "Vozilo",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder MigrationBuilder)
        {
            MigrationBuilder.DropForeignKey(
                name: "FK_TuristRuta_Kategorije_KategorijaId",
                table: "TuristRuta");

            MigrationBuilder.DropForeignKey(
                name: "FK_Vozac_Kategorije_KategorijaId",
                table: "Vozac");

            MigrationBuilder.DropForeignKey(
                name: "FK_Vozilo_Kategorije_KategorijaId",
                table: "Vozilo");

            MigrationBuilder.DropIndex(
                name: "IX_Vozilo_KategorijaId",
                table: "Vozilo");

            MigrationBuilder.DropIndex(
                name: "IX_Vozac_KategorijaId",
                table: "Vozac");

            MigrationBuilder.DropIndex(
                name: "IX_TuristRuta_KategorijaId",
                table: "TuristRuta");

            MigrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "Vozilo");

            MigrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "Vozac");

            MigrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "TuristRuta");
        }
    }
}
