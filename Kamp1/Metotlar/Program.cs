using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("say hi");

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 50;
            product1.Description = "Best Apple";
            product1.Id = 1;

            Product product2 = new Product();
            product2.Name = "Orange";
            product2.Price = 60;
            product2.Description = "Best Orange For Now";
            product2.Id = 2;

            Product[] products = new Product[] { product1, product2 };

            //Type safe - tip güvenli
            foreach (var product in products)
            {
                Console.WriteLine("-----------------------");

                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Id);
            }
            Console.WriteLine("-----------Metotlar-----------");
            //encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Ekle(product1);
            basketManager.Ekle(product2);

            basketManager.Ekle2("armut", "best armut", 37);
        }
    }
}


// do not repeat yourself - DRY - Clean Code - Best Practice
