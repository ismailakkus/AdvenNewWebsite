namespace AdvenNewWebsite.Areas.Admin.Models
{
    public class HaberModel
    {
        public int HaberID { get; set; }
        public string? HaberBaslik { get; set; }
        public string? HaberIcerik { get; set; }
        public string? HaberFoto { get; set; }
        public IFormFile? ResimUpload { get; set; }
        public string? HaberKaynak { get; set; }
        public string? HaberLink { get; set; }
        public bool? Anasayfa { get; set; }
        public int OkunmaSayisi { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool? AktifMi { get; set; }
    }
}
