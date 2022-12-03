using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        //void nedir ?
        // void de direkt yap bitsin gibisinden tek seferlik
        //int olarak yazdığımızda return ile değerleri geri dönebilmemizi sağlar (tekrar tekrar kullanabilmemizi)

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);

        //}


    }
}
