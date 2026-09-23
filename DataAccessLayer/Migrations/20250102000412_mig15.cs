using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sureclers",
                columns: table => new
                {
                    SurecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurecAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurecAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurecIkon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sureclers", x => x.SurecID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sureclers");
        }
    }
}
