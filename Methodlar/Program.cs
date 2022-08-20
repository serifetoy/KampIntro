using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");

            Product product1 = new Product(); // class tanımlaması yapıyoruz
            // Product elma = new Product();

            Product urun1 = new Product();

            urun1.Adi = "Karpuz";
            urun1.Fiyati = 15 ;
            urun1.Aciklama= "Diyarbakır Karpuzu";

            Product urun2 = new Product();
            urun2.Adi = "Elma";
            urun2.Fiyati = 14;
            urun2.Aciklama = "Amasya Elması";

            Product[] urunler = new Product[] {urun1, urun2};

            foreach (Product aliasurun in urunler ) //aliasurun - dönecek olan urun1 ve urun2 yi temsil eder
            {
                Console.WriteLine(aliasurun.Adi);
                Console.WriteLine(aliasurun.Fiyati);
                Console.WriteLine(aliasurun.Aciklama);
                Console.WriteLine("-----------------");

            }

            Console.WriteLine("----Metodlar-----");


            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);


            sepetmanager.Ekle2("Armut", "yesil", 12,5);
            sepetmanager.Ekle2("elma", "kırmızı", 15,7);
            sepetmanager.Ekle2("portakal", "adana", 17,9);
        }
    }
}

//metotlar tekrar tkerar kullanılabilen bir ortam sağlıyor
