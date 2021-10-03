using System;
using System.Collections.Generic;

namespace Dictionarry
{
    class MyDictionary<TKey,TValue>
    {

        TKey[] _arrayKeys;
        TValue[] _arrayValues;

        public MyDictionary()
        {
            _arrayKeys = new TKey[0];
            _arrayValues = new TValue[0];
        }

    
    }
   

}
