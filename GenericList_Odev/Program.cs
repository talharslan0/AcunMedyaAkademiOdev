using GenericList_Odev.Generic;



public class Program
{
	public static void Main()
	{
		List<Araba<Marka, Model>> arabas = new List<Araba<Marka, Model>>
		{
			new Araba<Marka, Model> { Marka = new Marka { marka = "Toyota" }, Model = new Model { model = "Corolla" }, yakit = 6.5, toplamMesafe = 5000 },
			new Araba<Marka, Model> { Marka = new Marka { marka = "BMW" }, Model = new Model { model = "X5" }, yakit = 9.0, toplamMesafe = 5000 },
			new Araba<Marka, Model> { Marka = new Marka { marka = "Mercedes" }, Model = new Model { model = "C200" }, yakit = 8.2, toplamMesafe = 5000 }
		};

		foreach (var araba in arabas)
		{
			araba.Yazdir();
		}
	}
}