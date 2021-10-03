using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {





        }
    }



    class MyDictionary<TKey,TValue>
    {

        TKey[] arrayKeys;
        TValue[] arrayValues;


        TKey[] temparrayKeys;
        TValue[] temparrayValues;


        public MyDictionary()
        {
            arrayKeys = new TKey[0];
            arrayValues = new TValue[0];
        }

        public void Add(TKey key , TValue value)
        {

            temparrayKeys = arrayKeys;
            temparrayValues = arrayValues;


            arrayKeys = new TKey[arrayKeys.Length+1];
            arrayValues = new TValue[arrayValues.Length + 1];


            for (int i = 0; i < temparrayKeys.Length; i++)
            {
                arrayKeys[i] = temparrayKeys[i];
            }

            for (int i = 0; i < temparrayValues.Length; i++)
            {
                arrayValues[i] = temparrayValues[i];

            }

            arrayKeys[arrayKeys.Length - 1] = key;
            arrayValues[arrayValues.Length - 1] = value;





        }


    }

}
