/*Dynamic Array
 https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1146/
*/
using System;
using System.Collections;
class String02_DynamicArray
{
    static void Main02()
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
        arrayList1.IndexOf(5);
    }
}