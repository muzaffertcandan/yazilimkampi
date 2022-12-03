using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{   
    /*snippet*/
    class Product
    {
        public int ID { get; set; }
        //categories
        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        //stok adedi
        public int UnitInStock { get; set; }
        
    }
}
