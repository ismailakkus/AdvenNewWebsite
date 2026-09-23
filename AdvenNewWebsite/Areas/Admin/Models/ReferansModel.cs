namespace AdvenNewWebsite.Areas.Admin.Models
{
    public class ReferansModel
    {
        public int ReferansID { get; set; }
        public string? ReferansAdi { get; set; }
        public string? ReferansLogo { get; set; }
        public IFormFile? ResimUpload { get; set; }
        public bool? AktifMi { get; set; }
    }
}
