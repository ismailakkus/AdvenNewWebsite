using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BuroTescilNo",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FaaliyetAlani",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Konum",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MersisNo",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NaceKodu",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SSKNo",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SirketAdi",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TicariSicilNo",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "BuroTescilNo",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "FaaliyetAlani",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "Konum",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "MersisNo",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "NaceKodu",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "SSKNo",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "SirketAdi",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "TicariSicilNo",
                table: "Ayarlars");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Ayarlars");
        }
    }
}
