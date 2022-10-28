using System;

namespace Kamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type safety
            //do not repeat yourself
            //deger tutucu, allias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 17.45;
            double dolarBugun = 18.05;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış oku");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("artış oku");

            }
            else
            {
                Console.WriteLine("değişmedi oku");
            }


            if (sistemeGirisYapmisMi ==true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
