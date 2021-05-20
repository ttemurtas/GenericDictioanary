using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDictioanary
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _key;
        private TValue[] _value;
        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey keys, TValue values)
        {
            TKey[] tempKey = _key;
            TValue[] tempValue = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                _value[i] = tempValue[i];
            }

            _key[_key.Length - 1] = keys;
            _value[_value.Length - 1] = values;
        }

    }
}
