namespace AdvenNewWebsite.Areas.Admin.Models
{
    public class KullaniciModel
    {
        public int KullaniciID { get; set; }
        public string? AdiSoyadi { get; set; }
        public string? KullaniciEmail { get; set; }
        public string? KullaniciSifre { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public string? Notlar { get; set; }
        public string? Resim { get; set; }
        public IFormFile? ResimUpload { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool? AktifMi { get; set; }
    }
}
