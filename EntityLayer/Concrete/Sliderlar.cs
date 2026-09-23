using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sliderlar
    {
        [Key]
        public int SliderID { get; set; }
        public string SliderBaslik { get; set; }
        public string SliderAciklama { get; set; }
        public string SliderFoto { get; set; }
        public string SliderLink { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public bool? AktifMi { get; set; }
    }
}
