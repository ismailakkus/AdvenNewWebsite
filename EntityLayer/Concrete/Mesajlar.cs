using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mesajlar
    {
        [Key]
        public int MesajID { get; set; }
        public string MesajBaslik { get; set; }
        public string MesajIcerik { get; set; }
        public string MesajKategori { get; set; }
        public string GonderenAdSoyad { get; set; }
        public string GonderenMail { get; set; }
        public string GonderenTelefon { get; set; }
        public string GonderenEk { get; set; }
        public bool? Okundu { get; set; }
        public bool? Onemli { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool? AktifMi { get; set; }
    }
}
