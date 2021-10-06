using System;
using System.Collections.Generic;

namespace Coding_AHashTable06
{
    class Problem_Dictionary_AggregateByKey
    {
        static void Main01()
        {
            AggregateByKey(new List<int> { 1, 2, 1 });
        }
        /*
        * Template for using hash map to find duplicates.
        * Replace ReturnType with the actual type of your return value.
        */
        static bool AggregateByKey(List<int> keys)
        {
            // Replace Type and InfoType with actual type of your key and value
            Dictionary<int, int> hashmap = new Dictionary<int, int>();
            foreach (int key in keys)
            {
                if (hashmap.ContainsKey(key))
                {
                    Console.WriteLine("Key has already taken");
                }
                // Value can be any information you needed (e.g. index)
                hashmap.Add(key, 25);
            }
            return false;
        }
    }
}
