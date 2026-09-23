using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Surecler
    {
        [Key]
        public int SurecID { get; set; }
        public string SurecAdi { get; set; }
        public string SurecAciklama { get; set; }
        public string SurecIkon { get; set; }
        public bool? AktifMi { get; set; }
    }
}
