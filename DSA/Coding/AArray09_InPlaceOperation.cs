using System;

namespace Coding_AArray09
{
    class AArray09_InPlaceOperation
    {
        static void Main09()
        {
            squareEven(new int[] { 9, -2, -9, 11, 56, -12, -3 }, 7);
            squareEven_InPlace(new int[] { 9, -2, -9, 11, 56, -12, -3 }, 7);
        }
        public static int[] squareEven(int[] array, int length)
        {

            // Check for edge cases.
            if (array == null)
            {
                return null;
            }

            // Create a resultant Array which would hold the result.
            int[] result = new int[length];

            // Iterate through the original Array.
            for (int i = 0; i < length; i++)
            {

                // Get the element from slot i of the input Array.
                int element = array[i];

                // If the index is an even number, then we need to square element.
                if (i % 2 == 0)
                {
                    element *= element;
                }

                // Write element into the result Array.
                result[i] = element;
            }

            // Return the result Array.
            return result;
        }

        public static int[] squareEven_InPlace(int[] array, int length)
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
