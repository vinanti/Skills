/*
 Reverse to Make Equal
Given two arrays A and B of length N, determine if there is a way to make A equal to B by reversing any subarrays from array B any number of times.
Signature
bool areTheyEqual(int[] arr_a, int[] arr_b)
Input
All integers in array are in the range [0, 1,000,000,000].
Output
Return true if B can be made equal to A, return false otherwise.
Example
A = [1, 2, 3, 4]
B = [1, 4, 3, 2]
output = true
After reversing the subarray of B from indices 1 to 3, array B will equal array A.
 */

using System;
using System.Linq;
using System.Collections.Generic;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
class ReverseToMakeEqual
{
    static void Main001(string[] args)
    {
        //Q. A or B can be empty - yes - 
        //yes - Q. if both empty - true
        //equality - if not equal - false
        //Q. A is sorted? yes, B not

        //Approach
        //1. check both empty? true
        //2. either empty - false
        //3. Both array of equal length? not - false
        //4. Sort B - LinQ Sort() method 
        //5. are equal - Brut force O(n) - LinQ IsEqual() method 

        // Call areTheyEqual() with test cases here

        //Case 1 - Ans: True
        int[] A1 = new int[] { };
        int[] B1 = new int[] { };
        Console.WriteLine(areTheyEqual(A1, B1));

        //Case 2  - Ans: False
        int[] A2 = new int[] { 1, 2, 3, 4 };
        int[] B2 = new int[] { };
        Console.WriteLine(areTheyEqual(A2, B2));

        //Case 3  - Ans: False
        int[] A3 = new int[] { 1, 2, 3, 4 };
        int[] B3 = new int[] { 1, 4 };
        Console.WriteLine(areTheyEqual(A3, B3));

        //Case 4  - Ans: True
        int[] A4 = new int[] { 1, 2, 3, 4 };
        int[] B4 = new int[] { 1, 4, 3, 2 };
        Console.WriteLine(areTheyEqual(A4, B4));
    }

    private static bool areTheyEqual(int[] arr_a, int[] arr_b)
    {
        if (!arr_a.Any() && !arr_b.Any()) return true;
        if (!arr_a.Any() || !arr_b.Any()) return false;
        if (arr_a.Length == arr_b.Length)
        {
            Array.Sort(arr_b);
            return string.Join("", arr_a) == string.Join("", arr_b);
        }
        return false;
    }
}
