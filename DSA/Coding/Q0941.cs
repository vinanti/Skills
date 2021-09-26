using System;

namespace Coding_Q0941
{
    class Q0941
    {
        static void Main941()
        {
            Console.WriteLine(ValidMountainArray(new int[] { 0, 2, 3, 4, 5, 2, 1, 0 }));
            Console.WriteLine(ValidMountainArray(new int[] { 0, 2, 3, 3, 5, 2, 1, 0 }));
            Console.WriteLine(ValidMountainArray(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Console.WriteLine(ValidMountainArray(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }));
        }
        public static bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3) return false;
            bool flag = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (!flag && arr[i] > arr[i + 1] && i>0) flag = true;
                if (!flag)
                {
                    if (arr[i] >= arr[i + 1]) return false;
                }
                else
                {
                    if (arr[i] <= arr[i + 1]) return false;
                }
            }
            return flag;
        }
    }
}
