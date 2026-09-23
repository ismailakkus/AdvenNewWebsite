using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Ayarlars",
                newName: "LogoLight");

            migrationBuilder.AddColumn<string>(
                name: "LogoDark",
                table: "Ayarlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoDark",
                table: "Ayarlars");

            migrationBuilder.RenameColumn(
                name: "LogoLight",
                table: "Ayarlars",
                newName: "Logo");
        }
    }
}
