/*Q203 Array Capacity VS Length
 https://leetcode.com/explore/featured/card/fun-with-arrays/521/introduction/3295/
 
 */

using System;

namespace Q203ns
{
    class Q203
    {
        static void Main203(string[] args)
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

            int[] nums = new int[] { 1, 1, 1, 2, 1, 5, 1, 8, 1, 0, 1, 8, 1 };
            Console.WriteLine(FindMaxConsecutiveOnes(nums));

        }
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            // Hint: Initialise and declare a variable here to 
            // keep track of how many 1's you've seen in a row.
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // Do something with element nums[i].
                if (nums[i] == 1)
                    count++;
            }
            return count;
        }
    }
    public class DVD
    {
        public string name;
        public int releaseYear;
        public string director;

        public DVD(string name, int releaseYear, string director)
        {
            this.name = name;
            this.releaseYear = releaseYear;
            this.director = director;
        }

        public string toString()
        {
            Console.WriteLine(
                this.name + ", directed by " + this.director + ", released in " + this.releaseYear);
            return string.Empty;
        }
    }
}