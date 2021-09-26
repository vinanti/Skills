using System;

namespace Coding_Q0026
{
    class Q0026
    {
        static void Main26()
        {
            int n = RemoveDuplicates(new int[] { 0 });
        }
        static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int j = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    j++;
                    nums[j] = nums[i + 1];
                }
            }
            return j+1;
        }
    }
}
