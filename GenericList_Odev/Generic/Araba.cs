using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList_Odev.Generic
{
	public class Araba
	{
		public string marka { get; set; }
		public string model { get; set; }
		public double harcananBenzin { get; set; } 
		public double toplamMesafe { get; set; } 

		public double yakitTuketimi()
		{
			return (harcananBenzin * toplamMesafe) / 100;
		}
	}
}
