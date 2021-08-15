/*In-P,lace Array Operations*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class Q216
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 9, -2, -9, 11, 56, -12, -3 };
            nums = squareEven(nums, nums.Length);
            foreach(var n in nums)
                Console.WriteLine(n);
        }
        public static int[] squareEven(int[] array, int length)
        {

            // Check for edge cases.
            if (array == null)
            {
                return array;
            }

            // Iterate through the original array.
            for (int i = 0; i < length; i++)
            {

                // If the index is an even number, then we need to square the element
                // and replace the original value in the Array.
                if (i % 2 == 0)
                {
                    array[i] *= array[i];
                }
                // Notice how we don't need to do *anything* for the odd indexes? :-)
            }

            // We just return the original array. Some problems on leetcode require you
            // to return it, and other's dont.
            return array;
        }
    }
}
