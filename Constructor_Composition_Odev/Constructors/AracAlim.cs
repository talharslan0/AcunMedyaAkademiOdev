using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Odev.Constructors
{
	public class AracAlim
	{
		public Arac arac;
		public string Ad;
		public string SoyAd;
		public double Fiyat;

		public AracAlim(string Ad, string SoyAd, double Fiyat, Arac arac)
		{
			this.Ad = Ad;
			this.SoyAd = SoyAd;
			this.Fiyat = Fiyat;
			this.arac = arac;
		}

		public void AracSatis()
		{
			Console.WriteLine("************** Araç satın alan kişinin **************\n" +
				"Adı:" + Ad +
				"\nSoyadı:" + SoyAd +
				"\n********** Aldığı aracın **********" +
				
				"\nMarkası:" + arac.marka.marka +
				"\nModeli:" + arac.model.model +
				"\nRengi:" + arac.renk.renk +
				"\nKasası:" + arac.kasa.kasa +
				"\nTrafiğe Çıkış Yılı:" + arac.cikisYili.trafigecikisyili +
				"\nŞasi No:" + arac.sasiNo.sasino+
				"\nFiyat:" + Fiyat +"TL");
		}
	}
}
