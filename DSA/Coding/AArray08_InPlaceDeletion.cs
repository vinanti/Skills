using System;

namespace Coding_AArray08
{
    class AArray08_InPlaceDeletion
    {
        static void Main08()
        {
            Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 })); //5
            CopyWithRemovedDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }); //[0, 1, 2, 3, 4]
        }
        public static int RemoveDuplicates(int[] nums)
        {

            // The initial length is simply the capacity.
            int length = nums.Length;

            // Assume the last element is always unique.
            // Then for each element, delete it iff it is
            // the same as the one after it. Use our deletion
            // algorithm for deleting from any index.
            for (int i = length - 2; i >= 0; i--)
            {
                if (nums[i] == nums[i + 1])
                {
                    // Delete the element at index i, using our standard
                    // deletion algorithm we learned.
                    for (int j = i + 1; j < length; j++)
                    {
                        nums[j - 1] = nums[j];
                    }
                    // Reduce the length by 1.
                    length--;
                }
            }
            // Return the new length.
            return length;
        }
        public static int[] CopyWithRemovedDuplicates(int[] nums)
        {

            // Check for edge cases.
            if (nums == null || nums.Length == 0)
            {
                return nums;
            }

            // Count how many unique elements are in the Array.
            int uniqueNumbers = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // An element should be counted as unique if it's the first
                // element in the Array, or is different to the one before it.
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    uniqueNumbers++;
                }
            }

            // Create a result Array.
            int[] result = new int[uniqueNumbers];

            // Write the unique elements into the result Array.
            int positionInResult = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // Same condition as in the previous loop. Except this time, we can write
                // each unique number into the result Array instead of just counting them.
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    result[positionInResult] = nums[i];
                    Console.WriteLine(nums[i]);
                    positionInResult++;
                }
            }
            return result;
        }
    }
}
