using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Projeler
    {
        [Key]
        public int ProjeID { get; set; }
        public string ProjeAdi { get; set; }
        public string ProjeResim { get; set; }
        public string ProjeOzet { get; set; }
        public string ProjeAciklama { get; set; }
        public string ProjeKonum { get; set; }
        public string ProjeKategori { get; set; }
        public string ProjeYatirimci { get; set; }
        public string ProjeDurum { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}
