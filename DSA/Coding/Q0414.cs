using System;

namespace Coding_Q0414
{
    class Q0414
    {
        static void Main414()
        {
            ThirdMax(new int[] { 3, 2, 1 }); //1
            ThirdMax(new int[] { 1, 2 }); //2
            ThirdMax(new int[] { 2, 2, 3, 1 }); //1
        }
        public static int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            int thirdMax = nums[0], count = 3;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] > nums[i - 1]) count--;
                if (count == 0)
                {
                    thirdMax = nums[i];
                    break;
                }
            }
            if (count > 0) { thirdMax = nums[0]; count--; }
            if (count > 0) thirdMax = nums[nums.Length - 1];
            return thirdMax;
        }
    }
}
