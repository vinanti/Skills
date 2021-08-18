/* Sort Array by Parity
 https://leetcode.com/problems/sort-array-by-parity/

 905. Sort Array By Parity
Easy

1957

99

Add to List

Share
Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

Return any array that satisfies this condition.

 

Example 1:

Input: nums = [3,1,2,4]
Output: [2,4,3,1]
Explanation: The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
Example 2:

Input: nums = [0]
Output: [0]
 

Constraints:

1 <= nums.length <= 5000
0 <= nums[i] <= 5000

 
 */
using System;
namespace Q015ns
{
    class Q015
    {
        static void Main015()
        {
            Console.WriteLine("Parity 1");
            int[] nums1 = { 3, 1, 2, 4 };
            nums1 = SortArrayByParity(nums1);
            foreach(int n in nums1)
                Console.WriteLine(n);

            Console.WriteLine("Parity 2");
            int[] nums2 = { };
            nums1 = SortArrayByParity(nums2);
            foreach (int n in nums2)
                Console.WriteLine(n);

            Console.WriteLine("Parity 3");
            int[] nums3 = { 0, 1 };
            nums1 = SortArrayByParity(nums3);
            foreach (int n in nums3)
                Console.WriteLine(n);
        }
        static int[] SortArrayByParity(int[] nums)
        {
            if (nums.Length < 2) return nums;
            int low = 0, high = nums.Length - 1;
            while (low < high)
            {
                if (nums[low] % 2 == 1 && nums[high] % 2 == 0)
                {
                    nums[low] += nums[high];
                    nums[high] = nums[low] - nums[high];
                    nums[low] = nums[low] - nums[high];
                    low++; high--;
                }
                else
                {
                    if (nums[low] % 2 == 0) low++;
                    if (nums[high] % 2 == 1) high--;
                }
            }
            return nums;
        }
    }
}