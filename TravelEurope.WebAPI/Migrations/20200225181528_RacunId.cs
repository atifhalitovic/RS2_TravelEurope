using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class RacunId : Migration
    {
        protected override void Up(MigrationBuilder MigrationBuilder)
        {
            MigrationBuilder.AlterColumn<int>(
                name: "RacunId",
                table: "Rezervacija",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder MigrationBuilder)
        {
            MigrationBuilder.AlterColumn<int>(
                name: "RacunId",
                table: "Rezervacija",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
