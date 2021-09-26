using System;

namespace Coding_Q1131
{
    class Q1131
    {
        public int MaxAbsValExpr(int[] arr1, int[] arr2)
        {
            int max = 0, current = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    current = Math.Abs(arr1[i] - arr1[j]) + Math.Abs(arr2[i] - arr2[j]) + Math.Abs(i - j);
                    max = Math.Max(max, current);
                }
            }
            return max;
        }
    }
}
