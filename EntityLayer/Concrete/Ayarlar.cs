using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ayarlar
    {
        [Key]
        public int AyarID { get; set; }
        public string LogoLight { get; set; }
        public string LogoDark { get; set; }
        public string SiteAdi { get; set; }
        public string SiteAdresi { get; set; }
        public string SiteTelNo { get; set; }
        public string SiteTanimi { get; set; }
        public string SiteKeyword { get; set; }
        public string SiteEposta { get; set; }
        public string MailServer { get; set; }
        public string MailSifre { get; set; }
        public int? MailGelenPort { get; set; }
        public int? MailGidenPort { get; set; }

        public string? SirketAdi { get; set; }
        public string? NaceKodu { get; set; }
        public string? FaaliyetAlani { get; set; }
        public string? Adres { get; set; }

        public string? Telefon { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? Konum { get; set; }

        public string? MersisNo { get; set; }
        public string? TicariSicilNo { get; set; }
        public string? SSKNo { get; set; }
        public string? BuroTescilNo { get; set; }

        public string? BankaHesap1 { get; set; }
        public string? IBANTL1 { get; set; }
        public string? IBANUSD1 { get; set; }

        public string? BankaHesap2 { get; set; }
        public string? IBANTL2 { get; set; }
        public string? IBANUSD2 { get; set; }

        public string? BankaHesap3 { get; set; }
        public string? IBANTL3 { get; set; }
        public string? IBANUSD3 { get; set; }

    }
}
