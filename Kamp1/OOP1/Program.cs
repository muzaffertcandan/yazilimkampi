using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2; //furniture
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product
            {
                ID = 2,
                CategoryId = 5,
                UnitInStock = 3,
                ProductName = "Pencil",
                UnitPrice = 3
            };
            //pascal case ilk harfi büyük ProductManager
            //camel case productManager
            // case sensitive - küçük büyük harf duyarlıdır
            //stack tarafı                    //heap tarafı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);

            //int, bool double değer tiplerdir, atamalar tamamen değer üzerinden olup bağlantılar kopar,
            //diziler class, abstract class, interface ... referans tiplerdir, fonksiyona yollandığında 101 olan bellek adresi değişiyor örnek 102 oluyor.

        }
    }
}
