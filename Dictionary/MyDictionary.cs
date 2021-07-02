using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        K[] tempKeys;
        V[] values;
        V[] tempValues;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }
        public void Add(K key,V value)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            values[values.Length - 1] = value;
        }
        public int Length
        {
            get { return keys.Length; }
        }
    }
}
