/*Q120 Given an array and a value, remove all instances of that value in-place and return the new length.
 https://leetcode.com/explore/learn/card/array-and-string/205/array-two-pointer-technique/1157/

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class Q120
    {
        static void Main120()
        {
            int[] nums = new int[] { 1, 2, 3, 3, 3, 4, 3, 5, 3, 6, 3, 7, 3, 8, 3, 9 };
            Console.WriteLine(removeElement(nums, 3));
        }
        public static int removeElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
