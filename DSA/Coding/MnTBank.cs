using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class MnTBank
    {
        static void Main()
        {
            int a = solution(new int[] { 6, 1, 4, 6, 3, 2, 7, 4 }, 3, 2);
        }
        public static int solution(int[] A, int K, int L)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length < K + L) return -1;
            int maxAppleCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i + K <= A.Length && (L <= i || L <= A.Length - (i + K)))
                    maxAppleCount = Math.Max(maxAppleCount, GetSumOfKElements(A, i, K) + GetSumOfLElements(A, i, K + i, L));
            }
            return maxAppleCount;
        }
        public static int GetSumOfKElements(int[] A, int i, int K)
        {
            int sum = 0;
            while (K > 0)
            {
                sum += A[i];
                i++; K--;
            }
            return sum;
        }
        public static int GetSumOfLElements(int[] A, int i1, int i2, int L)
        {
            int[] leftArray = new int[i1];
            int[] rightArray = new int[A.Length - i2];
            Array.Copy(A, 0, leftArray, 0, i1);
            Array.Copy(A, i2, rightArray, 0, A.Length - i2);
            int sum = 0;
            if (leftArray.Length >= L)
            {
                for (int i = 0; i < leftArray.Length; i++)
                {
                    if (i + L <= leftArray.Length)
                        sum = Math.Max(sum, GetSumOfKElements(leftArray, i, L));
                }
            }
            if (rightArray.Length >= L)
            {
                for (int i = 0; i < rightArray.Length; i++)
                {
                    if (i + L <= rightArray.Length)
                        sum = Math.Max(sum, GetSumOfKElements(rightArray, i, L));
                }
            }
            return sum;
        }
    }
}
