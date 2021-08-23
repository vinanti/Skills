/*Array Capacity VS Length
 Handling Array Parameters
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class Array03_CapacityVsLength
    {
        static void Main03()
        {
            // Create a new array with a capacity of 6.
            int[] array = new int[6];

            // Current length is 0, because it has 0 elements.
            int length = 0;

            // Add 3 items into it.
            for (int i = 0; i < 3; i++)
            {
                array[i] = i * i;
                // Each time we add an element, the length goes up by one.
                length++;
            }
            Console.WriteLine("The Array has a capacity of " + array.Length);
            Console.WriteLine("The Array has a length of " + length);

            int[] nums1 = new int[] { 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1 };
            Console.WriteLine(findMaxConsecutiveOnes(nums1));
        }

    //Given a binary array, find the maximum number of consecutive 1s in this array.
        public static int findMaxConsecutiveOnes(int[] nums)
        {
            // Hint: Initialise and declare a variable here to 
            int maxConsecutiveOnes = 0;
            int consecutiveOnes = 0;
            // keep track of how many 1's you've seen in a row.
            for (int i = 0; i < nums.Length; i++)
            {
                // Do something with element nums[i].
                if (nums[i] == 1) consecutiveOnes++;
                else
                {
                    if (maxConsecutiveOnes < consecutiveOnes) maxConsecutiveOnes = consecutiveOnes;
                    consecutiveOnes = 0;
                }
            }
            return maxConsecutiveOnes;
        }
    }
}
