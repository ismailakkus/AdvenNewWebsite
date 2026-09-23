using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hizmetler
    {
        [Key]
        public int HizmetID { get; set; }
        public string HizmetAdi { get; set; }
        public string Aciklama { get; set; }
        public string Foto { get; set; }
        public bool? Anasayfa { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool? AktifMi { get; set; }
    }
}
