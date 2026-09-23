namespace AdvenNewWebsite.Areas.Admin.Models
{
    public class SliderModel
    {
        public int SliderID { get; set; }
        public string? SliderBaslik { get; set; }
        public string? SliderAciklama { get; set; }
        public string? SliderFoto { get; set; }
        public IFormFile? ResimUpload { get; set; }
        public string? SliderLink { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool? AktifMi { get; set; }
    }
}
