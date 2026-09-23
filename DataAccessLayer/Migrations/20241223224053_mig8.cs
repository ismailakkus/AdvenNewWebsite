using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Kullanicilars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notlar",
                table: "Kullanicilars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Kullanicilars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Kullanicilars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Kullanicilars");

            migrationBuilder.DropColumn(
                name: "Notlar",
                table: "Kullanicilars");

            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Kullanicilars");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Kullanicilars");
        }
    }
}
