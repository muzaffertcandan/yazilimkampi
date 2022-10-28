using System;

namespace ClassAmazon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products products1 = new Products();
            products1.Name = "LG TV";
            products1.Price = 1000;
            products1.Energy = "G";

            Products products2 = new Products();
            products2.Name = "Vestel TV";
            products2.Price = 2500;
            products2.Energy = "G";

            Products products3 = new Products();
            products3.Name = "Samsung TV";
            products3.Price = 3000;
            products3.Energy = "F";

            Products[] product = new Products[]
            {
                products1, products2, products3
            };
            Console.WriteLine("for loop");

            for (int i = 0; i < product.Length; i++) {
                Console.WriteLine("Ürün Adı:" + product[i].Name + " Enerji tipi: " + product[i].Energy + " Fiyat: " + product[i].Price + ".");  
            }
            Console.WriteLine("foreach loop");
            foreach ( var myProduct in product)
            {
                Console.WriteLine(myProduct.Name + myProduct.Energy + myProduct.Price);
            }
            int j = 0;
            Console.WriteLine("while loop");
            while (j< product.Length)
            {
                Console.WriteLine("Ürün Adı:" + product[j].Name + " Enerji tipi: " + product[j].Energy + " Fiyat: " + product[j].Price + ".");
                j++;
            }

        }
    }


    class Products
    {
        public string Name { get; set; }
        
        public int Price { get; set; }

        public string Energy { get; set; }
    }
}
