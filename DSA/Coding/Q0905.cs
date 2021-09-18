using System;

namespace Coding
{
    class Q0905
    {
        static void Main905()
        {
            SortArrayByParity(new int[] { 3, 1, 2, 4 }); //2,4,3,1
        }
        public static int[] SortArrayByParity(int[] nums)
        {
            if (nums.Length < 2) return nums;
            int low = 0, high = nums.Length - 1;
            while (low < high)
            {
                if (nums[low] % 2 == 1 && nums[high] % 2 == 0)
                {
                    nums[low] += nums[high];
                    nums[high] = nums[low] - nums[high];
                    nums[low] = nums[low] - nums[high];
                    low++; high--;
                }
                else
                {
                    if (nums[low] % 2 == 0) low++;
                    if (nums[high] % 2 == 1) high--;
                }
            }
            return nums;
        }
    }
}
