using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety-tip güvenliği //do not repeat yourself-kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmişMi = true;//gerçek hayatta burası veri kaynağından gelir
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }

            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmişMi == true)
            {

                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



            
            Console.WriteLine(kategoriEtiketi);//değer tutucu kategorietiketi


           

        }
    }
}
