using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun uruntakma in urunler)
            {

                Console.WriteLine(uruntakma.Adi);
                Console.WriteLine(uruntakma.Fiyati);
                Console.WriteLine(uruntakma.Aciklama);


            }

            Console.WriteLine("------Metotlar----");

            //instance- örnek// metot çağırma
            //encapsulation-kapsülleme 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("elma", "kırmızı elma", 18,8);
            sepetManager.Ekle2("karpuz", "Yeşil armut", 20,7);




        }
    }
}
