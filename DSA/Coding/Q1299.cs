/*Replace Elements with Greatest Element on Right Side*/
using System;

namespace Coding
{
    class Q1299
    {
        static void Main1299()
        {
            ReplaceElements(new int[] { 17, 18, 5, 4, 6, 1 }); //18,6,6,6,1,-1
        }
        public static int[] ReplaceElements(int[] arr)
        {
            if (arr == null) return arr;
            for (int i = 0; i < arr.Length; i++)
            {
                int max = -1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (max < arr[j]) max = arr[j];
                }
                arr[i] = max;
            }
            return arr;
        }
    }
}
