using Constructor_Composition_Odev.Classes;
using Constructor_Composition_Odev.Constructors;
using static Constructor_Composition_Odev.Constructors.Generic;

Marka marka = new Marka("Bmw");
Model model = new Model("X5");
Kasa kasa=new Kasa("Suv");
Renk renk = new Renk("Siyah");
SasiNo sasiNo = new SasiNo("A123B321C456");
TrafigeCikisYili cikisYili = new TrafigeCikisYili(2025);
Arac arac=new Arac(kasa, marka, model, renk, sasiNo, cikisYili);
AracAlim aracAlim = new AracAlim("Talha", "Arslan", 2000000, arac);
aracAlim.AracSatis();



//-------------------------------------------------------------------
Matematik matematik = new Matematik();
Console.WriteLine("****************************************************");
Console.WriteLine("2 Sayının Toplamı: "+ matematik.topla(7,3));
Console.WriteLine("3 Sayının Toplamı: "+ matematik.topla(7,3,6));
Console.WriteLine("4 Sayının Toplamı: "+ matematik.topla(7,3,2,8));
Console.WriteLine("****************************************************");
Console.WriteLine("2 Sayının Çarpımı: "+ matematik.carpma(12.32,10.43).ToString("F2"));
Console.WriteLine("3 Sayının Çarpımı: "+ matematik.carpma(12,10,14));
Console.WriteLine("4 Sayının Çarpımı: "+ matematik.carpma(12.32,10.43,34.12,45).ToString("F2"));
Console.WriteLine("****************************************************");

Console.ReadKey();
