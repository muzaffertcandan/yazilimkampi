using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class BasketManager
    {
        //naming convention -syntax

        public void Ekle(Product product)
        {
            Console.WriteLine("sepete eklendi: " + product.Name);
        }

        public void Ekle2(string name, string description, double price)
        {
            Console.WriteLine("sepete eklendi: " + name);
        }
    }
}
