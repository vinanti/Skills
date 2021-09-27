using System;

namespace Coding_Q0027
{
    class Q0027
    {
        static void Main0027()
        {
            int i = RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
        }
        static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            int j = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] != val) {
                    nums[j] = nums[i];
                    j++;
                } 
            }
            return j;
        }
    }
}
