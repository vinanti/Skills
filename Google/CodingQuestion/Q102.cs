/*Operations in Dynamic Array
 https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1146/
        // 1. initialize a List 
        // 2. cast an array to a List
        // 3. make a copy
        // 4. get length
        // 5. access element
        // 6. iterate the List
        // 7. modify element
        // 8. sort
        // 9. add new element at the end of the List
        // 10. delete the last element

Error:
Linq ditective shoude declare as Sustem.Linq.
ArrayList belongs to System>Collections directives.
Length of araayList is captured by .Count menthod
Console.Writeline missed double quote
array element refer by [] not {]
delete elemt shoud mention which elemt to delete.
*/
using System;
using System.Linq;
using System.Collections;
namespace Q102ns
{
    class Q102
    {
        static void Main102(string[] args)
        {
            ArrayList array = new ArrayList();
            int[] nums = new int[] {2, 5, 1, 4, 3 };
            array.Add(nums);
            ArrayList array2 = new ArrayList(nums.ToList());
            ArrayList array3 = array2;
            Console.WriteLine("array Length: " + array3.Count);
            Console.WriteLine("element at index 2: " + array3[2]);
            Console.WriteLine("array Elements:");
            foreach(var a in array3)
                Console.WriteLine(a);
            array3[3] = 14;
            Console.WriteLine("Modified element at index 3 as 14:" + array3[3]);
            array3.Sort();
            Console.WriteLine("Sorted Array:");
            foreach(var a in array3)
                Console.WriteLine(a);
            Console.WriteLine("Element added at end of array:");
            array3.Add(6);
            foreach(var a in array3)
                Console.WriteLine(a);
            Console.WriteLine("Element deleted at end of array:");
            array3.Remove(1);
            foreach(var a in array3)
                Console.WriteLine(a);
        }
    }
}

