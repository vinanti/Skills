using System;
using System.Collections.Generic;

namespace Coding
{
    class AHashTable06_DictionaryAggregateByKey
    {
        static void Main06()
        {

        }
        /*
        * Template for using hash map to find duplicates.
        * Replace ReturnType with the actual type of your return value.
        */
        bool AggregateByKey_hashmap(List<int> keys)
        {
            // Replace Type and InfoType with actual type of your key and value
            Dictionary<int, int> hashmap = new Dictionary<int, int>();
            foreach (int key in keys)
            {
                if (hashmap.ContainsKey(key))
                {
                    hashmap.Add(key, 15);
                }
                // Value can be any information you needed (e.g. index)
                hashmap.Add(key, 25);
            }
            return false;
        }
    }
}
