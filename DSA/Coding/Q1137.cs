using System;

namespace Coding
{
    class Q1137
    {
        static void Main1137()
        {
            Tribonacci(5);
        }
        public static int Tribonacci(int n)
        {
            if (n < 3) return n == 0 ? 0 : 1;
            int tmp, x = 0, y = 1, z = 1;
            for (int i = 3; i <= n; ++i)
            {
                tmp = x + y + z;
                x = y;
                y = z;
                z = tmp;
            }
            return z;
        }

        public static int Tribonacci01(int n)
        {
            if (n == 0) return 0;
            if (n < 3) return 1;
            return Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3);
            
        }
    }
}
