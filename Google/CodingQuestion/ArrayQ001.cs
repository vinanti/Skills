/*Max Consecutive Ones
https://leetcode.com/explore/featured/card/fun-with-arrays/521/introduction/3238/
https://leetcode.com/problems/max-consecutive-ones/
 Given a binary array nums, return the maximum number of consecutive 1's in the array.

Example 1:

Input: nums = [1,1,0,1,1,1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.

Example 2:

Input: nums = [1,0,1,1,0,1]
Output: 2
 

Constraints:

1 <= nums.length <= 105
nums[i] is either 0 or 1.
 */
using System;

namespace CodingQuestion
{
    class ArrayQ001
    {
        static void Main001()
        {
            int[] nums1 = new int[] { 1, 1, 0, 1, 1, 1 }; //3
            Console.WriteLine(findMaxConsecutiveOnes(nums1));

            int[] nums2 = new int[] { 1, 0, 1, 1, 0, 1 };  //2
            Console.WriteLine(findMaxConsecutiveOnes(nums2));
        }

        //Given a binary array, find the maximum number of consecutive 1s in this array.
        public static int findMaxConsecutiveOnes(int[] nums)
        {
            // Hint: Initialise and declare a variable here to 
            int maxConsecutiveOnes = 0;
            int consecutiveOnes = 0;
            // keep track of how many 1's you've seen in a row.
            for (int i = 0; i < nums.Length; i++)
            {
                // Do something with element nums[i].
                if (nums[i] == 1) consecutiveOnes++;
                else
                {
                    if (maxConsecutiveOnes < consecutiveOnes) maxConsecutiveOnes = consecutiveOnes;
                    consecutiveOnes = 0;
                }
            }
            return maxConsecutiveOnes > consecutiveOnes? maxConsecutiveOnes : consecutiveOnes; 
        }
    }
}
