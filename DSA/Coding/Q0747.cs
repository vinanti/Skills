using System;
using System.Linq;

namespace Coding_Q0747
{
    class Q0747
    {
        static void Main747()
        {
            DominantIndex(new int[] { 3, 6, 1, 0 });  //1
        }
        public static int DominantIndex(int[] nums)
        {
            int largestNumber = nums.Max();
            for (int i = 0; i < nums.Length; i++)
            {
                if (largestNumber != nums[i] && largestNumber < (nums[i] * 2)) return -1;
            }
            return Array.IndexOf(nums, largestNumber);
        }
    }
}
