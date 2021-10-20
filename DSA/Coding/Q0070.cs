using System;

namespace Coding
{
    class Q0070
    {
        static void Main70()
        {
            int steps = ClimbStairs(5);
        }
        public static int ClimbStairs(int n)
        {
            return climb_Stairs(0, n);
        }
        public static int climb_Stairs(int i, int n)
        {
            if (i > n)
            {
                return 0;
            }
            if (i == n)
            {
                return 1;
            }
            return climb_Stairs(i + 1, n) + climb_Stairs(i + 2, n);
        }
    }
}
