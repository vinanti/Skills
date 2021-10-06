//Array Capacity VS Length
using System;

namespace Coding_Array04
{
    class AArray04_CapacityVsLength
    {
        static void Main04()
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
        }
    }
}
