using System;

namespace Coding
{
    class Q0300
    {
        static void Main300()
        {
            LengthOfLIS(new int[] { 0, 1, 0, 3, 2, 3 });
        }
        public static int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            Array.Fill(dp, 1);

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            int longest = 0;
            foreach(int c in dp)
            {
                longest = Math.Max(longest, c);
            }

            return longest;
        }
    }
}
