using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Haberler
	{
		[Key]
		public int HaberID { get; set; }
		public string HaberBaslik { get; set; }
		public string HaberIcerik { get; set; }
		public string HaberFoto { get; set; }
		public string HaberKaynak { get; set; }
		public string? HaberLink { get; set; }
		public bool? Anasayfa { get; set; }
        public int OkunmaSayisi { get; set; }
        public DateTime? EklemeTarihi { get; set; }
		public bool? AktifMi { get; set; }
	}
}
