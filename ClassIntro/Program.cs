using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 16;

            Kurs kurs1= new Kurs(); //yeni sınıf bu şekilde tanımlanır.
            //kendi veri tipini yazıyorsun gibi
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani= 68;
            kurs1.Egitmen = "Engin Demirog";


            Kurs kurs2 = new Kurs(); 
            kurs2.KursAdi = "Java";
            kurs2.IzlenmeOrani = 15;
            kurs2.Egitmen = "kenan Demirog";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.IzlenmeOrani = 75;
            kurs3.Egitmen = "Berkay Demirog";

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            
            
            //string[] kurslar = new string[] { }; -> bu şekilde sadece string tutarsın
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        //prop diyip 2 kere tab ile oluşturduk aşağıdaki kısımları, kursun özellikleri propertiesden geliyor
        // get set şimdilik önemli değil
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
