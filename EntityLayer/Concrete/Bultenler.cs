using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bultenler
    {
        [Key]
        public int MailID { get; set; }
        public string MailAdresi { get; set; }
    }
}
