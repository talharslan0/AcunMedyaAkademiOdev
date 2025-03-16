class Program
{
	static void Main()
	{
		while (true)
		{
			Random rnd = new Random();
			int rastgeleSayi = rnd.Next(1, 101);
			int tahmin = 0;
			int tahminSayisi = 0;

			Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin!");

			while (tahmin != rastgeleSayi)
			{
				Console.Write("Tahmininiz: ");
				string giris = Console.ReadLine();

				if (int.TryParse(giris, out tahmin))
				{
					tahminSayisi++;

					if (tahmin < rastgeleSayi)
					{
						Console.WriteLine("Daha büyük bir sayı girin.");
					}
					else if (tahmin > rastgeleSayi)
					{
						Console.WriteLine("Daha küçük bir sayı girin.");
					}
					else
					{
						Console.WriteLine($"Tebrikler! {tahminSayisi} tahminde doğru sayıyı buldunuz.");
					}
				}
				else
				{
					Console.WriteLine("Lütfen geçerli bir sayı girin.");
				}
			}

			Console.Write("Tekrar oynamak ister misiniz? (E/H): ");
			string cevap = Console.ReadLine().ToUpper();
			if (cevap != "E")
			{
				break;
			}
		}
	}
}