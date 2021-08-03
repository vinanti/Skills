/*Median Stream
You're given a list of n integers arr[0..(n-1)]. You must compute a list output[0..(n-1)] such that, for each index i (between 0 and n-1, inclusive), output[i] is equal to the median of the elements arr[0..i] (rounded down to the nearest integer).
The median of a list of integers is defined as follows. If the integers were to be sorted, then:
If there are an odd number of integers, then the median is equal to the middle integer in the sorted order.
Otherwise, if there are an even number of integers, then the median is equal to the average of the two middle-most integers in the sorted order.
Signature
int[] findMedian(int[] arr)
Input
n is in the range [1, 1,000,000].
Each value arr[i] is in the range [1, 1,000,000].
Output
Return a list of n integers output[0..(n-1)], as described above.
Example 1
n = 4
arr = [5, 15, 1, 3]
output = [5, 10, 5, 4]
The median of [5] is 5, the median of [5, 15] is (5 + 15) / 2 = 10, the median of [5, 15, 1] is 5, and the median of [5, 15, 1, 3] is (3 + 5) / 2 = 4.
Example 2
n = 2
arr = [1, 2]
output = [1, 1]
The median of [1] is 1, the median of [1, 2] is (1 + 2) / 2 = 1.5 (which should be rounded down to 1).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAChallenges
{
    class MedianStream
    {
        static void Main5(string[] args)
        {
            int[] arr = new int[] { 5, 15, 1, 3 };
            for (int i = 1; i <= arr.Length; i++)
                Console.Write(arr[i - 1] + "    ");
            Console.WriteLine();
            int[] result = findMedian(arr);
            for (int i = 1; i <= result.Length; i++)
                Console.Write(result[i - 1] + "    ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            int[] arr2 = new int[] { 1, 2 };
            for (int i = 1; i <= arr2.Length; i++)
                Console.Write(arr2[i - 1] + "    ");
            Console.WriteLine();
            int[] result2 = findMedian(arr2);
            for (int i = 1; i <= result2.Length; i++)
                Console.Write(result2[i - 1] + "    ");
        }

        private static int[] findMedian(int[] arr)
        {
            int[] result = new int[arr.Length];
            result[0] = arr[0];
            result[1] = (arr[0] + arr[1]) / 2;
            for (int i = 2; i < arr.Length; i++)
            {
                if ((i+1) % 2 == 1)
                    result[i] = arr.Take(i+1).OrderBy(x => x).Where((x, index) => index == i / 2).First();
                else
                    result[i] = arr.Take(i+1).OrderBy(x => x).Where((x, index) => index >= i/2 && index <= (i/2 + 1)).Sum()/2;
            }
            return result;
        }
    }
}
