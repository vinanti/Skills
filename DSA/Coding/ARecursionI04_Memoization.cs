using System;
using System.Collections.Generic;

namespace Coding_ARecursionI04
{
    public class ARecursionI04_Memoization
    {
        static Dictionary<int, int> cache = new Dictionary<int, int>();
        private static int Fib(int N)
        {
            if (cache.ContainsKey(N))
            {
                return cache[N];
            }
            int result;
            if (N < 2)
            {
                result = N;
            }
            else
            {
                result = Fib(N - 1) + Fib(N - 2);
            }
            // keep the result in cache.
            cache.Add(N, result);
            return result;
        }
        static void Main04()
        {
            int result = Fib(5);
        }
    }
}
