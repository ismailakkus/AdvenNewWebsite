using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ayarlars",
                columns: table => new
                {
                    AyarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteTelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteTanimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteKeyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteEposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailServer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailGelenPort = table.Column<int>(type: "int", nullable: true),
                    MailGidenPort = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ayarlars", x => x.AyarID);
                });

            migrationBuilder.CreateTable(
                name: "Haberlers",
                columns: table => new
                {
                    HaberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaberBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaberIcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaberFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaberKaynak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaberLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haberlers", x => x.HaberID);
                });

            migrationBuilder.CreateTable(
                name: "Hizmetlers",
                columns: table => new
                {
                    HizmetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetlers", x => x.HizmetID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilars",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilars", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Loglars",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    GirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loglars", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "Mesajlars",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesajBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajIcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GonderenAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GonderenMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GonderenTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Okundu = table.Column<bool>(type: "bit", nullable: true),
                    Onemli = table.Column<bool>(type: "bit", nullable: true),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlars", x => x.MesajID);
                });

            migrationBuilder.CreateTable(
                name: "Projelers",
                columns: table => new
                {
                    ProjeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjeAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjeKonum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjeKategori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjeYatirimci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjeDurum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projelers", x => x.ProjeID);
                });

            migrationBuilder.CreateTable(
                name: "Referanslars",
                columns: table => new
                {
                    ReferansID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferansAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferansLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referanslars", x => x.ReferansID);
                });

            migrationBuilder.CreateTable(
                name: "Sliderlars",
                columns: table => new
                {
                    SliderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliderlars", x => x.SliderID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ayarlars");

            migrationBuilder.DropTable(
                name: "Haberlers");

            migrationBuilder.DropTable(
                name: "Hizmetlers");

            migrationBuilder.DropTable(
                name: "Kullanicilars");

            migrationBuilder.DropTable(
                name: "Loglars");

            migrationBuilder.DropTable(
                name: "Mesajlars");

            migrationBuilder.DropTable(
                name: "Projelers");

            migrationBuilder.DropTable(
                name: "Referanslars");

            migrationBuilder.DropTable(
                name: "Sliderlars");
        }
    }
}
