using System;

namespace Coding
{
    class Q0167
    {
        static void Main167()
        {
            TwoSum(new int[] { 2, 7, 11, 15 }, 9); //[1,2]
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[i] + numbers[j] == target)
                        return new int[] { i + 1, j + 1 };
            return new int[] { 0, 0 };
        }
    }
}
