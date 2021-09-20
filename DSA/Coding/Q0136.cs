using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0136
    {
        static void Main136()
        {
            SingleNumber01(new int[] { 2, 2, 1 }); //1
            SingleNumber02(new int[] { 2, 2, 1 }); //1
        }

        //Approach 2: Using Hash Set
        public static int SingleNumber02(int[] nums)
        {
            HashSet<int> numberSet = new HashSet<int>();
            foreach (int n in nums)
            {
                if (!numberSet.Contains(n)) numberSet.Add(n);
                else numberSet.Remove(n);
            }
            int result = -1;
            foreach (int n in numberSet)
                result = n;
            return result;
        }

        //Approach 1: Using Array
        public static int SingleNumber01(int[] nums)
        {
            Array.Sort(nums);
            int single = nums[0];
            int count = 1;
            for (int n = 0; n < nums.Length - 1; n++)
            {
                if (nums[n] != nums[n + 1])
                {
                    if (count == 1) break;
                    single = nums[n + 1]; count = 1;
                }
                else { count++; }
            }
            return single;
        }
    }
}
