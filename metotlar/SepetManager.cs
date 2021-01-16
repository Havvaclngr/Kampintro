using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {

        // naming convention
        public void Ekle(Urun urun)//parametre urun oldu burada /urun elemanları içinde tutar
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + urun .Adi);


        }

        public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);
        }

    }
}
