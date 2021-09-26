using System;

namespace Coding_Q0075
{
    class Q0075
    {
        static void Main75()
        {
            SortColors(new int[] { 2, 0, 2, 1, 1, 0 });
        }
        public static void SortColors(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
    }
}
