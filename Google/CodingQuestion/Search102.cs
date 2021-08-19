/*Binary Search Iterative Algoritham*/
using System;

namespace CodingQuestion
{
    class Search102
    {
        static void Main1002()
        {
            int[] array = new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 };
            Console.WriteLine(BinarySearchIterative(array, 13));
        }
        public static bool BinarySearchIterative(int[] array, int x)
        {
            int left = 0;
            int right = array.Length - 1;
            while(left <= right)
            {
                int mid = left + ((right - left) / 2);
                if(array[mid] == x)
                {
                    return true;
                } else if (x < array[mid])
                {
                    right = mid - 1;
                } else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
    }
}
