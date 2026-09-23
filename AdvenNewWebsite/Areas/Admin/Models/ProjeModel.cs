namespace AdvenNewWebsite.Areas.Admin.Models
{
    public class ProjeModel
    {
        public int ProjeID { get; set; }
        public string? ProjeAdi { get; set; }
        public string? ProjeResim { get; set; }
        public string? ProjeOzet { get; set; }
        public IFormFile? ResimUpload { get; set; }
        public string? ProjeAciklama { get; set; }
        public string? ProjeKonum { get; set; }
        public string? ProjeKategori { get; set; }
        public string? ProjeYatirimci { get; set; }
        public string? ProjeDurum { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}
