/*Two Sum*/
/*
Q. Can be empty array? no, it will have atleast 2 elements
Q. Can be -Ve values in array or target?

Approch

*/

using System;
namespace Coding
{
    class Q0001
    {
        static void Main01()
        {
            TwoSum(new int[] { 3, 2, 4 }, 6);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
            return null;
        }
    }
}
