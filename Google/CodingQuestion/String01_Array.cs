/*Array
https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1143/
*/
using System;
class String01_Array
{
    static void Main001()
    {
        // 1. Initialize
        int[] array = new int[6] { 6, 3, 8, 7, 2, 9 };
        int[] array2 = new int[] { 1 };
        int[] array3;
        array3 = new int[] { 4, 5, 6 };
        int[] array4 = new int[5];
        array4 = new int[] { 1, 2, 3, 4, 5, 6 };
        array4 = new int[2] { 1, 3 };

        // 2. Get Length
        int length = array.Length;
        Console.WriteLine("Array Length is {0}", length);

        // 3. Access Element    
        Console.WriteLine("Element at index 2 and 5 are:" + array[2] + " and " + array[5]);

        // 4. Iterate all Elements
        Console.WriteLine("Elements of an array:");
        foreach (int a in array)
            Console.WriteLine(a);

        // 5. Modify Element
        array[3] = 10;
        Console.WriteLine("Modified element at index 3 as 10: " + array[3]);

        // 6. Sort
        Array.Sort(array);
        Console.WriteLine("Sorted Array:");
        foreach (int a in array)
        {
            Console.WriteLine(a);
        }

        //7. Index of element in ArrayList
        Array.IndexOf(array, 3);  //1
    }
}
