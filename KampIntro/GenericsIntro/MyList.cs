using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // Generic class
    class MyList<T>    // T tipinde
    {
        T[] items;     // T tipinde items
       
        // contructor (ctor tab tab yaptık, public MyList() oluştu) Amaç, items için Heap üzerinde referans oluşturmak. O nedenle new'lemek
        // gerekmektedir. Bunu yapabilmek için contructor'dan yararlandık.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;    
            items = new T[items.Length+1];  // items listesinin elemanını 1 arttırdık
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;  // aslında eklenmek istenen eleman şu an eklendi !!! items'ın sonuncu elemanı = "items.lenght-1"
        }

        public int Length 
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
