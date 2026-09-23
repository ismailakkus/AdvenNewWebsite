using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kullanicilar
    {
        [Key]
        public int KullaniciID { get; set; }
        public string AdiSoyadi { get; set; }
        public string KullaniciEmail { get; set; }
        public string KullaniciSifre { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public string? Notlar { get; set; }
        public string Resim { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool? AktifMi { get; set; }
    }
}
