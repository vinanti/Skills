/*Binary Search
 Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [-1,0,3,5,9,12], target = 9
Output: 4
Explanation: 9 exists in nums and its index is 4
Example 2:

Input: nums = [-1,0,3,5,9,12], target = 2
Output: -1
Explanation: 2 does not exist in nums so return -1
 

Constraints:

1 <= nums.length <= 104
-104 < nums[i], target < 104
All the integers in nums are unique.
nums is sorted in ascending order.
 */
using System;
class Search001
{
    static void Main()
    {
        Console.WriteLine(BinarySearch(new int[] {-1,0,3,5,9,12},9)); //4
        Console.WriteLine(BinarySearch(new int[] {-1,0,3,5,9,12},2));  //-1
        Console.WriteLine(BinarySearch(new int[] { 5 }, 5));  //0
    }
    static int BinarySearch(int[] nums, int target)
    {
        return BinarySearch(nums, target, 0, nums.Length-1);
    }
    static int BinarySearch(int[] nums, int target, int lowIndex, int highIndex)
    {
        if(lowIndex > highIndex) return -1;
        int midIndex = lowIndex + (highIndex - lowIndex)/2;
        if(nums[midIndex] == target)
            return midIndex;
        else if(nums[midIndex] > target)
            return BinarySearch(nums, target, lowIndex, midIndex-1);
        else
            return BinarySearch(nums, target, midIndex+1, highIndex);
        
    }
}


