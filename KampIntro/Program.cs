using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // do not repeat yourself - kendini tekrarlama
            // değer tutucu , alias
            string KategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000000;
            double Oran = 1.45;
            bool sistemeGirisYapmısMı = true;
            double DolarDun = 17.5;
            double DolarBugun = 17.5;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (DolarDun < DolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Sabit Butonu");
            }

            if (sistemeGirisYapmısMı== true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(KategoriEtiketi);



           
        }
    }
}
