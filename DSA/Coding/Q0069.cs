using System;

namespace Coding_Q0069
{
    class Q0069
    {
        static void Main69()
        {
            MySqrt(26);
        }
        public static int MySqrt(int x)
        {
            if (x == 1) return 1;
            long n = x / 2;
            while (n * n > x)
            {
                n = (n + (x / n)) / 2;
            }
            return (int)n;
        }
    }
}
