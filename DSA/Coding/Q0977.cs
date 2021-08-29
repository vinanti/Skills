using System;
class Q0977
{
    static int[] SortedSquares(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
            nums[i] = nums[i] * nums[i];
        Array.Sort(nums);
        return nums;
    }
    static void Main977()
    {
        int[] nums = SortedSquares(new int[] { -7,-3,2,3,11});
    }
}