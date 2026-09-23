using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Referanslar
    {
        [Key]
        public int ReferansID { get; set; }
        public string ReferansAdi { get; set; }
        public string ReferansLogo { get; set; }
        public bool? AktifMi { get; set; }
    }
}
