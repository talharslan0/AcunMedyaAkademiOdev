using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute_Ödevi
{
	public class Ogrenci
	{
		[ZorunluAlan("Ad alanı boş geçilemez.")]
		public string Ad { get; set; }

		[ZorunluAlan("Soyad alanı boş geçilemez.")]
		public string Soyad { get; set; }

		[ZorunluAlan("Bölüm alanı boş geçilemez.")]
		public string Bolum { get; set; }
	}
}
