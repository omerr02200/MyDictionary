using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Mylist<K, V>
    {
        K[] _arrayKey;
        V[] _arrayValue;
        public Mylist()
        {
            _arrayKey = new K[0];
            _arrayValue = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKey = _arrayKey;
            _arrayKey = new K[tempKey.Length + 1];

            V[] tempValue = _arrayValue;
            _arrayValue = new V[tempValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _arrayKey[i] = tempKey[i];
                _arrayValue[i] = tempValue[i];
            }

            _arrayKey[_arrayKey.Length - 1] = key;
            _arrayValue[_arrayValue.Length - 1] = value;
        }
    }
}
