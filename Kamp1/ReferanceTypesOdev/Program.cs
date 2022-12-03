using System;

namespace ReferanceTypesOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, euler, boolean deger tiplerdir



            // arrayler classlar interfaceler referance typetır

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;

            // referans tiplerde adresi değişiyor örnek sayilar1 in adresi 101 ise sayilar2 nin 102 ise sayilar1= sayilar2 olduğunda
            // sayilar1 artık 102 adresine bağlanır
            //stack                                     Heap
            // sayilar1, sayilar2                        { 1, 2, 3 },{ 10, 20, 30 }

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";


            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "salih";
            customer.CreditCardNumber = "234121512";

            Employee employee = new Employee();
            employee.FirstName = "veli";

            Person person3 = customer;
            customer.FirstName ="ahmet";

            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager= new PersonManager();
            personManager.Add(employee);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //base class(ebeveyn) : Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);


        }
    }
}
