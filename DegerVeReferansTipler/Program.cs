using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;// sayi2n değeri eşittir sayi1 se sayi1e geçer
            sayi2 = 65;

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;//sayilar2'nin referansı sayi1e geçer--diziler eşitlenince referans olarak eşitlenirler,
            sayilar2[0] = 999;

        }
    }
}
