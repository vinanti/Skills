/*4. Median of Two Sorted Arrays
 https://leetcode.com/problems/median-of-two-sorted-arrays/
 Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

 

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.
Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
Example 3:

Input: nums1 = [0,0], nums2 = [0,0]
Output: 0.00000
Example 4:

Input: nums1 = [], nums2 = [1]
Output: 1.00000
Example 5:

Input: nums1 = [2], nums2 = []
Output: 2.00000
 

Constraints:

nums1.length == m
nums2.length == n
0 <= m <= 1000
0 <= n <= 1000
1 <= m + n <= 2000
-106 <= nums1[i], nums2[i] <= 106
 */

using System;
using System.Collections.Generic;
public class Q204
{
    static void Main204()
    {
        double m = FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3,4 });
    }
    public static double FindMedianSortedArrays(int[] num1, int[] num2)
    {
        bool flag = (num1.Length + num2.Length) % 2 == 0;
        int m = (num1.Length + num2.Length) / 2 + 1;
        Stack<int> s = new Stack<int>();
        int i = 0, j = 0;
        while (m != 0)
        {
            if (i < num1.Length && j < num2.Length)
            {
                if(num1[i] < num2[j]){
                    s.Push(num1[i]);
                    i++;
                } else {
                    s.Push(num2[j]);
                    j++;
                }
            }
            else if (i >= num1.Length && j < num2.Length)
            {
                s.Push(num2[j]); j++;
            }
            else
            {
                s.Push(num1[i]); i++;
            }
            m--;
        }
        int median = s.Pop();
        if (flag)
        {
            median += s.Pop();
            return (double)median / 2;
        }
        else
            return median;
    }
}