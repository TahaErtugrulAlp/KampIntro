using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Generics classlar
    class MyList<T>
    {
        //Constructor denir. Alttaki boloğa. Bir class newlendiğinde çalışan bloğa constructor denir.
        //Arraylar referans tip olduğu için new'lenme zorunluluğu var.

        T[] items;
        public MyList()  //Constructor
        { 
           items = new T[0];
        }
        public void Add(T item)
        {
              //geçicidizi
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
          

        }
      

    }
}
