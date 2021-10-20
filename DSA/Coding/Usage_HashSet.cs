using System;
using System.Collections.Generic;

namespace Coding_AHashTable03
{
    class Usage_HashSet
    {
        public static void Main03()
        {
            //1.Initialize
            HashSet<int> hashSet = new HashSet<int>();

            //2.Size
            Console.WriteLine("The size of has set is: " + hashSet.Count);

            //3.Access 1st element
            //NA
            //Elements can be access only with iteration

            //4.Add element
            hashSet.Add(3);
            hashSet.Add(2);
            hashSet.Add(1);

            //5.Modify element
            //NA
            //Cant modify existing elemt, needs to delete and then add new

            //6.Remove element
            hashSet.Remove(2);

            //7.Remove all elements
            //hashSet.Clear();

            //8.Check if element exists
            if (!hashSet.Contains(2))
                Console.WriteLine("Key 2 is not in the hash set.");

            //9.Index of element
            //NA

            //10.Iterate elements
            foreach (int i in hashSet)
                Console.Write(i + " ");

            //Can't apply indexing to stack
            //for (int s = 0; s < hashSet.Count; s++)
            //    Console.WriteLine(hashSet[s] + " ");

            //11.Convert to array
            //NA

            //12.Copy elements to array
            int[] array = new int[10];
            hashSet.CopyTo(array, 3);

            //13.Sort
            //NA      

        }
    }
}
