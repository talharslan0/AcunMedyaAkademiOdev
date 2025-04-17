using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization_Odev.Classes
{
	[Serializable]
	public class Product
	{
		public string Marka;
		public string UrunAd;
		public decimal Fiyat;
		public string UrunKod;
		public DateTime Tarih;
	}
}
