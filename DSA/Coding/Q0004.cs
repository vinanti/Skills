using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0004
    {
        static void Main4()
        {
            FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }); //2
        }
        public static double FindMedianSortedArrays(int[] num1, int[] num2)
        {
            bool flag = (num1.Length + num2.Length) % 2 == 0;
            int m = (num1.Length + num2.Length) / 2 + 1;
            Stack<int> s = new Stack<int>();
            int i = 0, j = 0;
            while (m != 0)
            {
                if (i < num1.Length && j < num2.Length)
                {
                    if (num1[i] < num2[j])
                    {
                        s.Push(num1[i]);
                        i++;
                    }
                    else
                    {
                        s.Push(num2[j]);
                        j++;
                    }
                }
                else if (i >= num1.Length && j < num2.Length)
                {
                    s.Push(num2[j]); j++;
                }
                else
                {
                    s.Push(num1[i]); i++;
                }
                m--;
            }
            double median = s.Pop();
            if (flag)
            {
                median += s.Pop();
                return median / 2;
            }
            else
                return median;
        }
    }
}
