/*Max Consecutive Ones*/
//Bruit Force Solution
using System;
namespace coding_Q0485
{
    class Q0485
    {
        static void Main485()
        {
            int m = MaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }); //3
        }
        static int MaxConsecutiveOnes(int[] nums)
        {
            int max = 0, current = 0;
            foreach (int n in nums)
            {
                if (n == 1) current++;
                else current = 0;
                if (max < current) max = current;
            }
            return max;
        }
    }
}

//Optimized Solution
//using System;
//class Q0485
//{
//    static int MaxConsecutiveOnes(int[] nums)
//    {
//        int max = 0, currentMax = 0;
//        foreach (int n in nums)
//            max = Math.Max(max, currentMax = n == 0 ? 0 : ++currentMax);
//        return max;
//    }
//    static void Main485()
//    {
//        int m = MaxConsecutiveOnes(new int[] {1, 1, 0, 1, 1, 1}); //3
//    }
//}