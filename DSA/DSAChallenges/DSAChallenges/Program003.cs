//Heaps
/*Largest Triple Products
You're given a list of n integers arr[0..(n-1)]. You must compute a list output[0..(n-1)] such that, for each index i (between 0 and n-1, inclusive), output[i] is equal to the product of the three largest elements out of arr[0..i] (or equal to -1 if i < 2, as arr[0..i] then includes fewer than three elements).
Note that the three largest elements used to form any product may have the same values as one another, but they must be at different indices in arr.
Signature
int[] findMaxProduct(int[] arr)
Input
n is in the range [1, 100,000].
Each value arr[i] is in the range [1, 1,000].
Output
Return a list of n integers output[0..(n-1)], as described above.
Example 1
n = 5
arr = [1, 2, 3, 4, 5]
output = [-1, -1, 6, 24, 60]
The 3rd element of output is 3*2*1 = 6, the 4th is 4*3*2 = 24, and the 5th is 5*4*3 = 60.
Example 2
n = 5
arr = [2, 1, 2, 1, 2]
output = [-1, -1, 4, 4, 8]
The 3rd element of output is 2*2*1 = 4, the 4th is 2*2*1 = 4, and the 5th is 2*2*2 = 8.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAChallenges
{
    class LargestTripleProducts
    {
        static void Main6(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,5 };
            int[] signatureCounts = findMaxProduct(arr);
            for (int i = 1; i <= signatureCounts.Length; i++)
                Console.Write(signatureCounts[i - 1] + "    ");
            Console.WriteLine("--------------------------------");
            int[] arr2 = new int[] { 2,1,2,1,2 };
            int[] signatureCounts2 = findMaxProduct(arr2);
            for (int i = 1; i <= signatureCounts2.Length; i++)
                Console.Write(signatureCounts2[i - 1] + "    ");
        }

        private static int[] findMaxProduct(int[] arr)
        {
            int[] maxProduct = new int[arr.Length];
            maxProduct[0] = -1; maxProduct[1] = -1;
            for (int i=2; i<arr.Length; i++)
            {
                maxProduct[i] = arr.Take(i+1).OrderByDescending(x => x).Take(3).Aggregate((total, next) => total * next);
            }
            return maxProduct;
        }
    }
}
