﻿using System;
using System.Collections.Generic;

namespace Coding_AHashTable03
{
    class Usage_HashSet
    {
        public static void Main03()
        {
            // 1. initialize the hash set
            HashSet<int> hashSet = new HashSet<int>();

            // 2. add a new key
            hashSet.Add(3);
            hashSet.Add(2);
            hashSet.Add(1);

            
            // 3. remove the key
            hashSet.Remove(2);

            // 4. check if the key is in the hash set
            if (!hashSet.Contains(2))
            {
                Console.WriteLine("Key 2 is not in the hash set.");
            }

            // 5. get the size of the hash set
            Console.WriteLine("The size of has set is: " + hashSet.Count);

            // 6. iterate the hash set
            foreach(int i in hashSet)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("are in the hash set.");

            //Can't apply indexing to stack
            //for (int s = 0; s < hashSet.Count; s++)
            //    Console.WriteLine(hashSet[s] + " ");

            // 7. clear the hash set
            //hashSet.Clear();

            // 8. check if the hash set is empty
            if (hashSet.Count == 0)
            {
                Console.WriteLine("hash set is empty now!");
            }

            //9. Copy elements to array
            int[] array = new int[10];
            hashSet.CopyTo(array, 3);

            //10. Check if equal
            HashSet<int> hashSet2 = new HashSet<int>();
            hashSet.Equals(hashSet2);

        }
    }
}