//Writing/Reading items of Array with a loop
using System;

namespace Coding_Array03
{
    class AArray03_AccessElementsInLoop
    {
        static void Main03()
        {
            int[] squareNumbers = new int[10];

            // Go through each of the Array indexes, from 0 to 9.
            for (int i = 0; i < 10; i++)
            {
                // We need to be careful with the 0-indexing. The next square number
                // is given by (i + 1) * (i + 1).
                // Calculate it and insert it into the Array at index i.
                int square = (i + 1) * (i + 1);
                squareNumbers[i] = square;
            }
            // Go through each of the Array indexes, from 0 to 9.
            for (int i = 0; i < 10; i++)
            {
                // Access and print what's at the i'th index.
                Console.WriteLine(squareNumbers[i]);
            }

            // Will print:
            // 1
            // 4
            // 9
            // 16
            // 25
            // 36
            // 49
            // 64
            // 81
            // 100

            // For each VALUE in the Array.
            foreach(int square in squareNumbers)
            {
                // Print the current value of square.
                Console.WriteLine(square);
            }
            // Prints exactly the same as the previous example.
        }
    }
}
