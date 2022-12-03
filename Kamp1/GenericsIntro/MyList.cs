using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    // my List veri tipi olarak T ile çalışacak
     class MyList<T>
    {
        T[] items;
        //constructer
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            // elemanları geçici olarak tuttum
            T[] temArray = items;

            items = new T[items.Length + 1];

            // geçici elemanları ekleme
            for (int i = 0; i < temArray.Length; i++)
            {
                items[i] = temArray[i];
            }

            items[items.Length-1] = item;

        }

        


    }
}
