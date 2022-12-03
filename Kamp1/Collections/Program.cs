using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "engin", "murat", "muzaffer", "candan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //// diziler genişletilemiyor, diziye yeni bir şeyler eklenmeye çalışıldığında sıkıntı oluyor

            //// bellekte 2 kısım var bunlar       //stack                                        //heap
            //    //                              isimler                                      [ e, m, m, c,]
            //        //                          isimler

            //isimler = new string[5];
            //isimler[4] = "mtc";
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string> { "engin", "murat", "muzaffer", "candan" };
            //isimler2.Add("Engin")
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("ilker");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[4]);



        }
    }
}
