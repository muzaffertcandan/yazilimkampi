using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilim Yetistirme Kampi";
            string kurs2 = "Java";

            //Array dizi
            string[] kurslar = new string[] { "yazilim Yetistirme Kampi", "Java", "c#", "python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            //dizileri tek tek dolaşmaya yarar
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
