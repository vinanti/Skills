using System;

namespace Coding_Q0724
{
    class Q0724
    {
        static void Main724()
        {
            PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 }); //3
        }
        public static int PivotIndex(int[] nums)
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
