using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace Coding_AHashTable05
{
    class AHashTable05
    {
        static void Main01()
        {

            //1.Initialize
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            //2.Size
            Console.WriteLine("The size of hash map is: " + dictionary.Count);

            //3.Access 1st element
            dictionary.Add(1, 10);
            int x = dictionary.GetValueOrDefault(1);
            x = dictionary[1];

            //4.Add element
            if (!dictionary.ContainsKey(0))
                dictionary.Add(0, 0);
            if (!dictionary.ContainsKey(2))
                dictionary.Add(2, 3);

            //5.Modify element
            if (!dictionary.ContainsKey(1))
                dictionary.Add(1, 1);
            if (dictionary.ContainsKey(1))
                dictionary[1] = 2;
            if (dictionary.ContainsValue(2))
                dictionary[1] = 2;

            //6.Remove element
            dictionary.Remove(1);

            //7.Remove all elements
            //dictionary.Clear();

            //8.Check if element exists
            if (!dictionary.ContainsKey(1))
                Console.WriteLine("Key 2 is not in the hash map.");
            if (!dictionary.ContainsValue(2))
                Console.WriteLine("Key 2 is not in the hash map.");

            //9.Index of element
            //NA

            //10.Iterate elements
            foreach (KeyValuePair<int, int> pair in dictionary)
                Console.WriteLine("(" + pair.Key + "," + pair.Value + ") ");

            //11.Convert to array
            //NA

            //12.Copy elements to array
            //NA

            //13.Sort
            //NA

            List<int> keys = dictionary.Keys.ToList();
            List<int> values = dictionary.Values.ToList();
        }
    }
}
