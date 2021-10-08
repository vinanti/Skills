using System;

namespace Coding_AString01_ArrayOperations
{
    class Usage_Array
    {
        // "static void main" must be defined in a public class.
        static void Main01()
        {
            // 1. Initialize
            int[] array = new int[5];
            int[] array1 = { 1, 2, 3 };
            // 2. Get Length
            Console.WriteLine("The size of a1 is: " + array1.Length);
            // 3. Access Element
            Console.WriteLine("The first element is: " + array1[0]);
            // 4. Iterate all Elements
            Console.WriteLine("[Version 1: for loop] The contents of a1 are:");
            for (int i = 0; i < array1.Length; ++i)
            {
                Console.WriteLine(" " + array1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("[Version 2: for each] The contents of a1 are:");
            foreach (int item in array1)
            {
                Console.WriteLine(" " + item);
            }
            Console.WriteLine();
            // 5. Modify Element
            array1[0] = 4;
            // 6. Sort
            Array.Sort(array1);

            //7. Copy elements to array
            int[] a3 = new int[50];
            array1.CopyTo(a3, 1);

            //8. Check if equal
            array1.Equals(a3);

            
        }
    }
}
