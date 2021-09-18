using System;
using System.Collections;
using System.Collections.Generic;

namespace Coding
{
    class Q0448
    {
        static void Main448()
        {
            FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
        }
        public static IList<int> FindDisappearedNumbers_01(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == i + 1)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                if (nums[i] != i + 1) result.Add(i + 1);
            }
            return result;
        }

        public static List<int> FindDisappearedNumbers(int[] nums)
        {

            // Hash table for keeping track of the numbers in the array
            // Note that we can also use a set here since we are not 
            // really concerned with the frequency of numbers.
            Dictionary<int, bool> hashTable = new Dictionary<int, bool>();

            // Add each of the numbers to the hash table
            for (int i = 0; i < nums.Length; i++)
            {
                if(!hashTable.ContainsKey(nums[i]))
                    hashTable.Add(nums[i], true);
            }

            // Response array that would contain the missing numbers
            List<int> result = new List<int>();

            // Iterate over the numbers from 1 to N and add all those
            // that don't appear in the hash table. 
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!hashTable.ContainsKey(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
