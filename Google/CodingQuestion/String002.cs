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
class String002
{
    static void Main002()
    {
        // 1. initialize
        ArrayList array0 = new ArrayList();
        ArrayList array1;  // v1 == null

        // 2. cast an array to a vector
        int[] nums = new int[] { 2, 5, 1, 4, 3 };
        array1 = new ArrayList(nums);

        // 3. make a copy
        ArrayList array2 = array1;                      // another reference to v1
        ArrayList array3 = new ArrayList(array1);     // make an actual copy of v1

        /*
        // 3. get length
        System.out.println("The size of v1 is: " + v1.size());
        // 4. access element
        System.out.println("The first element in v1 is: " + v1.get(0));
        // 5. iterate the vector
        System.out.print("[Version 1] The contents of v1 are:");
        for (int i = 0; i < v1.size(); ++i)
        {
            System.out.print(" " + v1.get(i));
        }
        System.out.println();
        System.out.print("[Version 2] The contents of v1 are:");
        for (int item : v1)
        {
            System.out.print(" " + item);
        }
        System.out.println();
        // 6. modify element
        v2.set(0, 5);       // modify v2 will actually modify v1
        System.out.println("The first element in v1 is: " + v1.get(0));
        v3.set(0, -1);
        System.out.println("The first element in v1 is: " + v1.get(0));
        // 7. sort
        Collections.sort(v1);
        // 8. add new element at the end of the vector
        v1.add(-1);
        v1.add(1, 6);
        // 9. delete the last element
        v1.remove(v1.size() - 1);


        ArrayList array = new ArrayList();
        int[] nums = new int[] { 2, 5, 1, 4, 3 };
        array.Add(nums);
        ArrayList array2 = new ArrayList(nums.ToList());
        ArrayList array3 = array2;
        Console.WriteLine("array Length: " + array3.Count);
        Console.WriteLine("element at index 2: " + array3[2]);
        Console.WriteLine("array Elements:");
        foreach (var a in array3)
            Console.WriteLine(a);
        array3[3] = 14;
        Console.WriteLine("Modified element at index 3 as 14:" + array3[3]);
        array3.Sort();
        Console.WriteLine("Sorted Array:");
        foreach (var a in array3)
            Console.WriteLine(a);
        Console.WriteLine("Element added at end of array:");
        array3.Add(6);
        foreach (var a in array3)
            Console.WriteLine(a);
        Console.WriteLine("Element deleted at end of array:");
        array3.Remove(1);
        foreach (var a in array3)
            Console.WriteLine(a);

        */
    }
}