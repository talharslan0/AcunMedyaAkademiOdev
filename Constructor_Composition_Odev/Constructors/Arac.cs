using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Odev.Constructors
{
	public class Arac
	{
		public Kasa kasa;
		public Marka marka;
		public Model model;
		public Renk renk;
		public SasiNo sasiNo;
		public TrafigeCikisYili cikisYili;
		public Arac (Kasa kasa, Marka marka, Model model, Renk renk, SasiNo sasiNo, TrafigeCikisYili cikisYili)
		{
			this.kasa = kasa;
			this.marka = marka;
			this.model = model;
			this.renk = renk;
			this.sasiNo = sasiNo;
			this.cikisYili = cikisYili;
		}

	}
}
