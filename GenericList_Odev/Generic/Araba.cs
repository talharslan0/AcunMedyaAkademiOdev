using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList_Odev.Generic
{
	public class Araba<TMarka, TModel>
	{

		public TMarka Marka { get; set; }
		public TModel Model { get; set; }
		public double yakit { get; set; } 
		public double toplamMesafe { get; set; } 

		public double toplamYakitTuketimiHesapla()
		{
			return (toplamMesafe / 100) * yakit;
		}

		public void Yazdir()
		{
			double toplamYakitTuketimi = toplamYakitTuketimiHesapla();
			Console.WriteLine($"Marka: {((Marka as Marka)?.marka ?? "Eksik Bilgi Var")}, Model: {((Model as Model)?.model ?? "Eksik Bilgi Var")}, 100 km'de Yaktığı Yakıt: {yakit} litre, Toplam Yakıt Tüketimi: {toplamYakitTuketimi} litre");
		}
	}
}
