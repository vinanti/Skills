using System;

namespace Coding
{
    class Q0278
    {
        static void Main278()
        {
            FirstBadVersion(5);
        }
        public static int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        public static bool IsBadVersion(int n)
        {
            return n == 4;
        }
    }
}
