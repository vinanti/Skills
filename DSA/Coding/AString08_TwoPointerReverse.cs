using System;

namespace Coding_AString08
{
    class AString08_TwoPointerReverse
    {
        static void Main08()
        {
            Reverse(new int[] { 1, 2, 3, 4, 5, 6 },6);
        }
        public static void Reverse(int[] v, int N)
        {
            int i = 0;
            int j = N - 1;
            while (i < j)
            {
                int temp = v[i];
                v[i] = v[j];
                v[j] = temp;
                i++;
                j--;
            }
        }
    }
}
