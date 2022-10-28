using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "muzaffer";
            kurs1.IzlenmeOrani = 45;
           
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "engin demiroğ";
            kurs2.IzlenmeOrani = 27;
            
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c++";
            kurs3.Egitmen = "murat yücedağ";
            kurs3.IzlenmeOrani = 93;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " %" + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2, kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }


    }
}