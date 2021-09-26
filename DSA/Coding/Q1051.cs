using System;

namespace Coding_Q1051
{
    class Q1051
    {
        static void Main1051()
        {
            HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 }); //3
        }
        public static int HeightChecker(int[] heights)
        {
            int[] expected = new int[heights.Length];
            Array.Copy(heights, expected, heights.Length);
            int h = 0;
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = i+1; j < expected.Length; j++)
                {
                    if(expected[i] > expected[j])
                    {
                        int temp = expected[i];
                        expected[i] = expected[j];
                        expected[j] = temp;
                    }
                }
                if (heights[i] != expected[i]) h++;
            }
            return h;
        }
    }
}
