namespace AdvenNewWebsite.Areas.Admin.Models
{
    public class HizmetModel
    {
        public int HizmetID { get; set; }
        public string? HizmetAdi { get; set; }
        public string? Aciklama { get; set; }
        public IFormFile? ResimUpload { get; set; }
        public string? Foto { get; set; }
        public bool? Anasayfa { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool? AktifMi { get; set; }
    }
}
