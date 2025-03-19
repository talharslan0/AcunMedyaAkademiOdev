using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Odev.Classes
{
	public class Matematik
	{
		public int topla(int sayi1, int sayi2)
		{
			int toplamasonuc = 0;
			toplamasonuc = sayi1 + sayi2;
			return toplamasonuc;
		}
		public int topla(int sayi1, int sayi2,int sayi3)
		{
			int toplamasonuc = 0;
			toplamasonuc = sayi1 + sayi2 + sayi3;
			return toplamasonuc;
		}
		public int topla(int sayi1, int sayi2, int sayi3,int sayi4)
		{
			int toplamasonuc = 0;
			toplamasonuc = sayi1 + sayi2 + sayi3 + sayi4;
			return toplamasonuc;
		}

		public double carpma(double csayi1,double csayi2)
		{
			double carpmasonuc = 0;
			carpmasonuc= csayi1 * csayi2;
			return carpmasonuc;
		}

		public int carpma(int csayi1,int  csayi2, int csayi3)
		{
			int carpmasonuc = 0;
			carpmasonuc = csayi1 * csayi2 * csayi3;
			return carpmasonuc;
		}

		public double carpma(double csayi1,double csayi2,double csayi3,double csayi4)
		{
			double carpmasonuc = 0;
			carpmasonuc = csayi1 * csayi2 * csayi3 * csayi4;
			return carpmasonuc;
		}
	}
}
