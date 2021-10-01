using System;
using System.Collections.Generic;

namespace Coding_AHashTable05
{
    class AHashTable05_

    {
        // "static void main" must be defined in a public class.
        public static void Main05()
        {
            // 1. initialize a hash map
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            // 2. insert a new (key, value) pair
            if(!dictionary.ContainsKey(0))
                dictionary.Add(0, 0);
            if (!dictionary.ContainsKey(2))
                dictionary.Add(2, 3);

            // 3. insert a new (key, value) pair or update the value of existed key
            if (!dictionary.ContainsKey(1))
                dictionary.Add(1,1);
            if (dictionary.ContainsKey(1))
                dictionary[1] = 2;

            // 4. get the value of specific key
            Console.WriteLine("The value of key 1 is: " + dictionary[1]);

            // 5. delete a key
            dictionary.Remove(2);
            
            // 6. check if a key is in the hash map
            if (!dictionary.ContainsKey(2))
            {
                Console.WriteLine("Key 2 is not in the hash map.");
            }

            // 7. get the size of the hash map
            Console.WriteLine("The size of hash map is: " + dictionary.Count);

            // 8. iterate the hash map
            foreach(KeyValuePair<int, int> pair in dictionary)
            {
                Console.WriteLine("(" + pair.Key + "," + pair.Value + ") ");
            }
            Console.WriteLine("are in the hash map.");

            // 9. clear the hash map
            dictionary.Clear();

            // 10. check if the hash map is empty
            if (dictionary.Count == 0)
            {
                Console.WriteLine("hash map is empty now!");
            }
        }
    }
}
