using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "ahmet";
            students[2] = "salih";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
