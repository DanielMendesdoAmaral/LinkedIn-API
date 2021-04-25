using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AlterUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Geolocalização",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "Latitude",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Longitude",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Geolocalização",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
