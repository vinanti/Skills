using System;

namespace Coding_AString01_ArrayOperations
{
    class Usage_Array
    {

        static void Main01()
        {
            // 1. Initialize
            int[] array = new int[3];
            int[] array1 = { 1, 2, 3 };

            // 2. Size
            int length = array.Length;
            Console.WriteLine("The size of a1 is: " + length);

            // 3. Access Element
            Console.WriteLine("The first element is: " + array1[0]);

            // 4. Add element
            //array[5] = 50; Error: Index out of range
            //can't add new element, need to reinitialize

            // 5. Modify Element
            array1[0] = 4;

            // 6. Remove element
            //can't remove any element, need to reinitialize

            // 7. Remove all elements
            //NA

            // 8.Check if element exists
            //NA

            // 9.Index of element
            //NA

            // 10. Iterate all Elements
            Console.WriteLine("for loop:");
            for (int i = 0; i < array1.Length; ++i)
                Console.WriteLine(" " + array1[i]);

            Console.WriteLine("for each loop:");
            foreach (int item in array1)
                Console.WriteLine(" " + item);

            //11.Convert to array
            //NA

            //12.Copy elements to array
            int[] array3 = new int[10];
            array1.CopyTo(array3, 1);

            //13.Sort
            Array.Sort(array1);

        }
    }
}
