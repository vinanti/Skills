using System;

namespace Coding_ARecursionI05
{
    class ARecursionI05_TailRecursion
    {
        private static int helper_non_tail_recursion(int start, int[] ls)
        {
            if (start >= ls.Length)
            {
                return 0;
            }
            // not a tail recursion because it does some computation after the recursive call returned.
            return ls[start] + helper_non_tail_recursion(start + 1, ls);
        }

        public static int sum_non_tail_recursion(int[] ls)
        {
            if (ls == null || ls.Length == 0)
            {
                return 0;
            }
            return helper_non_tail_recursion(0, ls);
        }

        //---------------------------------------------

        private static int helper_tail_recursion(int start, int[] ls, int acc)
        {
            if (start >= ls.Length)
            {
                return acc;
            }
            // this is a tail recursion because the final instruction is the recursive call.
            return helper_tail_recursion(start + 1, ls, acc + ls[start]);
        }

        public static int sum_tail_recursion(int[] ls)
        {
            if (ls == null || ls.Length == 0)
            {
                return 0;
            }
            return helper_tail_recursion(0, ls, 0);
        }
    }
}
