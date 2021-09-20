/*Two Sum*/
/*
Q. Can be empty array? no, it will have atleast 2 elements
Q. Can be -Ve values in array or target?

Approch

*/

using System;
using System.Collections.Generic;
namespace Coding
{
    class Q0001
    {
        static void Main01()
        {
            TwoSum(new int[] { 3, 2, 4 }, 6);
        }
        //Approach 2: HashMap/Dictionary
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsValue(target - nums[i])) dictionary.Add(i, nums[i]);
                else
                {
                    foreach (KeyValuePair<int, int> pair in dictionary)
                    {
                        if (pair.Value == target - nums[i])
                            return new int[] { i, pair.Key };
                    }
                }
            }
            return null;
        }

        //Approach 1: Array/Brute Force
        public static int[] TwoSum01(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
            return null;
        }
    }
}
