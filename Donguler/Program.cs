using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Python";
            string kurs2 = "React";
            string kurs3 = "Java";

            //array

            //string array
            string[] kurslar = new string[] {"Python","React","Java" };

            for (int i = 0; i < kurslar.Length ; i++) //foreache göre daha genel bir kullanıma sahiptir
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //diz temelli yapıları tek tek dönmeye yarıyor
            { //kursları dolaş, kurs ismi aliastır farklı isim de verilebilir,
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
