/*Two-pointer Technique - Scenario I
 https://leetcode.com/explore/learn/card/array-and-string/205/array-two-pointer-technique/1156/
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class String07_TwoPointer
    {
        static void Main07()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }

            foreach(int a in arr)
                Console.WriteLine(a);
        }
    }
}
