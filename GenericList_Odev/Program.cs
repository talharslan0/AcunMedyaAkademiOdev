using GenericList_Odev.Generic;


List<Araba> araba = new List<Araba>
		{
			new Araba { marka = "Toyota", model = "Corolla", harcananBenzin = 13, toplamMesafe = 2000 },
			new Araba { marka = "BMW", model = "X5", harcananBenzin = 24.3, toplamMesafe = 2000 },
			new Araba { marka = "Mercedes", model = "C200", harcananBenzin = 20.2, toplamMesafe = 2000 }
		};

foreach (var yazdir in araba)
{
	Console.WriteLine($"Marka: {yazdir.marka}, Model: {yazdir.model}, 100 km'de Yaktığı Yakıt: {yazdir.harcananBenzin} litre, Toplam Yakıt Tüketimi: {yazdir.yakitTuketimi()} litre");
}