/*Array Insertions
 https://leetcode.com/explore/featured/card/fun-with-arrays/525/inserting-items-into-an-array/3244/

 */
using System;

namespace CodingQuestion
{
    class Array04_Insertions
    {
        static void Main04()
        {
            // Declare an integer array of 6 elements
            int[] intArray = new int[6];
            int length = 0;

            // Add 3 elements to the Array
            for (int i = 0; i < 3; i++)
            {
                intArray[length] = i;
                length++;
            }
            printArray(intArray, length);

            // *Insert a new element at the end of the Array*. Again,
            // it's important to ensure that there is enough space
            // in the array for inserting a new element.
            intArray[length] = 10;
            length++;

            printArray(intArray,length);

            //*Inserting at the Start of an Array*
            // First, we will have to create space for a new element.
            // We do that by shifting each element one index to the right.
            // This will firstly move the element at index 3, then 2, then 1, then finally 0.
            // We need to go backwards to avoid overwriting any elements.
            for (int i = 3; i >= 0; i--)
            {
                intArray[i + 1] = intArray[i];
            }

            // Now that we have created space for the new element,
            // we can insert it at the beginning.
            intArray[0] = 20;

            printArray(intArray, length);
        }
        static void printArray(int[] intArray, int length)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Index " + i + " contains " + intArray[i]);
            }
        }
    }
}
