/*Find Pivot Index
 https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1144/
Given an array of integers nums, calculate the pivot index of this array.

The pivot index is the index where 
the sum of all the numbers strictly to the left of the index 
is equal to 
the sum of all the numbers strictly to the index's right.

If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. 
This also applies to the right edge of the array.

Return the leftmost pivot index. If no such index exists, return -1.

Example 1:

Input: nums = [1,7,3,6,5,6]
Output: 3
Explanation:
The pivot index is 3.
Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
Right sum = nums[4] + nums[5] = 5 + 6 = 11
Example 2:

Input: nums = [1,2,3]
Output: -1
Explanation:
There is no index that satisfies the conditions in the problem statement.
Example 3:

Input: nums = [2,1,-1]
Output: 0
Explanation:
The pivot index is 0.
Left sum = 0 (no elements to the left of index 0)
Right sum = nums[1] + nums[2] = 1 + -1 = 0
 

Constraints:

1 <= nums.length <= 104
-1000 <= nums[i] <= 1000

 Q.Array empty? yes index = 0?

T.
[] -> -1
[5] -> 0
[1,7,3,6,5,6] -> 3  
L = 1 + 7 + 3
R = 6 + 5

[1,2,3] -> -1
[2,1,-1] -> 0
 
A.
1. array empty -> -1
2. single elemnt -> 0
3. L = 0, R = 0
4. Leftmost or rightmost, lesser will assign to sum L/R
5. Loop keep checking whichever sum is less add L/R most elements nest
6. If both equal then check howmany element left
7. If only 1 left return index
8. more than 1 left then continue 4

Error:
1. c small in class
2. 
 */

using System;

namespace Q103ns
{
    class StringQ001
    {
        static void Main103()
        {
            Console.WriteLine("Pivot Index:" + PivotIndex(new int[] { }));  //-1
            Console.WriteLine("Pivot Index:" + PivotIndex(new int[] { 5 }));  //0
            Console.WriteLine("Pivot Index:" + PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 }));  //3
            Console.WriteLine("Pivot Index:" + PivotIndex(new int[] { 1, 2, 3 }));  //-1
            Console.WriteLine("Pivot Index:" + PivotIndex(new int[] { 2, 1, -1 }));  //0

            //Not working with approach 1
            Console.WriteLine("Pivot Index:" + PivotIndex(new int[] { -1, -1, -1, -1, -1, 0 }));  //2
        }

        //Approach 1
        //static int PivotIndex(int[] nums)
        //{
        //    if(nums.Length == 0) return -1;
        //    if(nums.Length == 1) return 0;
        //    int leftSum = 0, rightSum = 0, leftIndex = 0, rightIndex = nums.Length -1;
        //    while(leftIndex != rightIndex) 
        //    {
        //        if(leftSum == rightSum)
        //        {
        //            if(nums[leftIndex] < nums[rightIndex] && leftIndex<rightIndex) 
        //                { leftSum += nums[leftIndex]; leftIndex++; }
        //            else 
        //                { rightSum += nums[rightIndex]; rightIndex--; }
        //        } else {
        //            if(leftSum < rightSum && leftIndex<rightIndex) 
        //                { leftSum += nums[leftIndex]; leftIndex++; }
        //            else 
        //                { rightSum += nums[rightIndex]; rightIndex--; }
        //        }
        //    }
        //    if(leftIndex == rightIndex && leftSum == rightSum) return leftIndex;
        //    else return -1;
        //}

        //Approach 2
        static int PivotIndex(int[] nums)
        {
            int sum = 0, leftsum = 0;
            foreach (int x in nums) sum += x;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (leftsum == sum - leftsum - nums[i]) return i;
                leftsum += nums[i];
            }
            return -1;
        }
    }
}

