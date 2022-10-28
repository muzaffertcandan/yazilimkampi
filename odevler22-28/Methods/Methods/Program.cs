using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();

            //var a = Add2(10);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.WriteLine(a);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1,2,3,4,5,6));
        }

        static void Add()
        {
            Console.WriteLine("added !!");
        }
        
        static int Add2(int number1 = 15, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }
        //ref ve out farkı - mantık olarak aynı farkı ref de gönderilecek değişkene kesinlikle değer atanmalı ancak out da öyle bir zorunluluk yok.
        // out da ise metodun içerisinde set edilmiş olması gerekir, metot dışında set edilmiş olmasının bir anlamı yok
        static int Add3(out int number3, int number2 )
        {
            number3 = 30;
            return number3 + number2;
        }

        static int Multiply (int number1, int number2 )
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //static int Add4(int number1, int number2)
        //{
        //    return number1 + number2;
        //}

        //params key word
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
