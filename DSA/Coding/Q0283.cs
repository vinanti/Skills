using System;

namespace Coding_Q0283
{
    class Q0283
    {
        static void Main283()
        {
            MoveZeroes(new int[] { 0, 1, 0, 3, 12 }); //1,3,12,0,0
            MoveZeroes(new int[] { 2, 1 }); //2,1
        }
        public static void MoveZeroes(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (i > j)
                    {
                        nums[j] = nums[i];
                        nums[i] = 0;
                    }
                    j++;
                }
            }
        }
    }
}
