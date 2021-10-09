using System;
using System.Collections;

namespace Coding_AString02
{
    
    public class Usage_ArrayList
    {
        static void Main01()
        {
            // 1. initialize
            ArrayList arrayList0 = new ArrayList() { 1, 2 };
            ArrayList arrayList1;  // v1 == null

            // 2. cast an array to a vector
            int[] nums = new int[] { 2, 5, 1, 4, 3 };
            arrayList1 = new ArrayList(nums);

            // 3. make a copy
            ArrayList arrayList2 = arrayList1;                      // another reference to v1
            ArrayList arrayList3 = new ArrayList(arrayList1);     // make an actual copy of v1

            // 3. get length
            Console.WriteLine("The size of arrayList1 is: " + arrayList1.Count);

            // 4. access element
            Console.WriteLine("The first element in arrayList1 is: " + arrayList1[0]);

            // 5. iterate the vector
            Console.WriteLine("[Version 1] The contents of arrayList1 are:");
            for (int i = 0; i < arrayList1.Count; i++)
            {
                Console.WriteLine(arrayList1[i]);
            }
            Console.WriteLine("[Version 2] The contents of arrayList1 are:");
            foreach (int item in arrayList1)
            {
                Console.WriteLine(item);
            }
            // 6. modify element
            arrayList2[0] = 5;      // modify v2 will actually modify v1
            Console.WriteLine("The first element in v1 is: " + arrayList1[0]);
            arrayList2.Insert(0, -1);
            Console.WriteLine("The first element in v1 is: " + arrayList1[0]);

            // 7. sort
            arrayList1.Sort();

            // 8. add new element at the end of the ArrayList
            arrayList1.Add(-1);
            arrayList1.Insert(3, 5);

            // 9. delete the last element
            arrayList1.Remove(5);
            arrayList1.RemoveAt(2);

            //10. Index of element in ArrayList
            int index = arrayList1.IndexOf(5);
            Console.WriteLine("Index of 5:" + index);

            //11.Remove all elements
            //arrayList0.Clear();

            //Check element exists
            arrayList0.Contains(5);

            int[] array = new int[50];
            arrayList0.CopyTo(array, 2);
        }
    }
}
