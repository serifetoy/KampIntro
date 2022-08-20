using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        //naming converntion
        public void Ekle( Product urun) //1.si tipi 2. si ismi 
        {
            Console.WriteLine(" Tebrikler...Sepete Eklendi: "+ urun.Adi);
            // Ekle çağrılınca  
        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine(" Tebrikler...Sepete Eklendi: " + urunAdi);
        }
    }
}
