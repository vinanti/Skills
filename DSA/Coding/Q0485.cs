using System;
class Q0485
{
    static int MaxConsecutiveOnes(int[] nums)
    {
        int max = 0, currentMax = 0;
        foreach (int n in nums)
            max = Math.Max(max, currentMax = n == 0 ? 0 : ++currentMax);
        return max;
    }
    static void Main485()
    {
        int m = MaxConsecutiveOnes(new int[] {1, 1, 0, 1, 1, 1}); //3
    }
}