/*Binary Search Recursive Algoritham*/
using System;

namespace CodingQuestion
{
    class Q1001
    {
        static void Main1001(string[] args)
        {
            int[] array = new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 };
            Console.WriteLine(BinarySearchRecursive(array,13));
        }
        public static bool BinarySearchRecursive(int[] array, int x)
        {
            return BinarySearchRecursive(array, x, 0, array.Length - 1);
        }
        public static bool BinarySearchRecursive(int[] array, int x, int left, int right)
        {
            if(left > right)
            {
                return false;
            }
            int mid = left + ((right - left) / 2);
            if(array[mid] == x)
            {
                return true;
            } else if (x < array[mid])
            {
                return BinarySearchRecursive(array, x, left, mid - 1);
            } else
            {
                return BinarySearchRecursive(array, x, mid + 1, right);
            }
        }

        
    }
}
