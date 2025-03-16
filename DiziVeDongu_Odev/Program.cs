class Program
{
	static void Main()
	{
		int[] sayilar = new int[5];
		int toplam = 0;

		for (int i = 0; i < 5; i++)
		{
			Console.Write($"{i + 1}. sayıyı girin: ");
			sayilar[i] = Convert.ToInt32(Console.ReadLine());
			toplam += sayilar[i]; 
		}
		double ortalama = (double)toplam / 5;

		Console.WriteLine($"Sayıların toplamı: {toplam}");
		Console.WriteLine($"Sayıların ortalaması: {ortalama}");
		Console.WriteLine("Çıkmak için bir tuşa basın...");
		Console.ReadKey();

	}
}