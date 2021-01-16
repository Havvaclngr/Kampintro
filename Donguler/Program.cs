using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım geliştirme","programlamaya geçiş","java"};//kurslar diye dizi tanımladık


            for (int i = 0; i <kurslar.Length; i++)//++ bir bir arttır i+2 iki iki arttır //lengt=eleman sayısı
            {
                Console.WriteLine(kurslar[i]);

            }

            Console.WriteLine("For bitti");

            foreach (string  kurs in kurslar)           //dizi temelli yapıları tek tek dönmeyi yarıyor //in kurslar(kursları dolaş)//kurs elamana verilen takma isim
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu");

        }
    }
}
