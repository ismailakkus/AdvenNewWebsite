using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Loglar
    {
        [Key]
        public int LogID { get; set; }
        public int? KullaniciID { get; set; }
        public DateTime? GirisTarihi { get; set; }
    }
}
