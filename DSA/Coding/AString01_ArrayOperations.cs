using System;

namespace Coding_AString01_ArrayOperations
{
    class AString01_ArrayOperations
    {
        // "static void main" must be defined in a public class.
        public static void Main01()
        {
            // 1. Initialize
            int[] a0 = new int[5];
            int[] a1 = { 1, 2, 3 };
            // 2. Get Length
            Console.WriteLine("The size of a1 is: " + a1.Length);
            // 3. Access Element
            Console.WriteLine("The first element is: " + a1[0]);
            // 4. Iterate all Elements
            Console.WriteLine("[Version 1] The contents of a1 are:");
            for (int i = 0; i < a1.Length; ++i)
            {
                Console.WriteLine(" " + a1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("[Version 2] The contents of a1 are:");
            foreach (int item in a1)
            {
                Console.WriteLine(" " + item);
            }
            Console.WriteLine();
            // 5. Modify Element
            a1[0] = 4;
            // 6. Sort
            Array.Sort(a1);
        }
    }
}
