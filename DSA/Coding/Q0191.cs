using System;

namespace Coding
{
    class Q0191
    {
        static void Main191()
        {
            HammingWeight(11);
        }
        public static int HammingWeight(uint n)
        {
            int count = 0, j = 0;
            for (int i = 1; i <= 32; i++)
            {
                uint sum = int.MaxValue;
                while (n <= sum)
                {
                    sum = (uint)Math.Pow(2, j);
                    j++;
                }
                if (n > 0)
                {
                    n -= (uint)Math.Pow(2, j - 1);
                    count++;
                }
                else break;
            }
            return count;
        }
    }
}
