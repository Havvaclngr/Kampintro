using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs Kurs1 = new Kurs();  //class değişkeni tanımlama
            Kurs1.KursAdi = "c#";
            Kurs1.Egitmen = "Havva ç";
            Kurs1.izlenme = 68;

            Kurs Kurs2 = new Kurs();  //class değişkeni tanımlama
            Kurs2.KursAdi = "java";
            Kurs2.Egitmen = "gözdi";
            Kurs2.izlenme = 55;

            Kurs Kurs3 = new Kurs();  //class değişkeni tanımlama
            Kurs3.KursAdi = "c++";
            Kurs3.Egitmen = "burcuş";
            Kurs3.izlenme = 30;

            Kurs[] kurslar = new Kurs[] {Kurs1, Kurs2, Kurs3 };

            foreach (Kurs kurstakma in kurslar)
            {
                Console.WriteLine(kurstakma.KursAdi + " " + kurstakma.Egitmen);
            }


            //Console.WriteLine(Kurs1.KursAdi + " " + Kurs1.Egitmen);

        }
    }

    class Kurs   //class oluşturma
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenme { get; set; }
    }
}
