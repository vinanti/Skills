using System;

namespace Coding
{
    class Q0050
    {
        static void Main50()
        {
            MyPow(2.00000, 10); //1024.00000
        }

        public static double MyPow(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            double ans = 1;
            for (long i = 0; i < N; i++)
                ans = ans * x;
            return ans;
        }
        public static double MyPow01(double x, int n)
        {
            bool negative = false;
            if (n < 0)
            {
                negative = true;
                n = Math.Abs(n);
            }
            double pow = 1;
            for (int i = 0; i < n; i++)
            {
                pow *= x;
            }
            if (negative)
                return 1 / pow;
            return pow;
        }
    }
}
