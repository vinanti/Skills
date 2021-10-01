using System;

namespace Coding_ARecursionII01
{
    public class ARecursionII01_DivideNConquerMergeSort
    {
        static void Main01()
        {
            int[] input = new int[] { 1, 5, 3, 2, 8, 7, 6, 4 };
            input =  Merge_sort(input);
        }
        public static int[] Merge_sort(int[] input)
        {
            if (input.Length <= 1)
            {
                return input;
            }
            int pivot = input.Length / 2;
            int[] left_list = new int[pivot];
            Array.Copy(input, 0, left_list, 0, pivot);
            left_list = Merge_sort(left_list);

            int[] right_list = new int[input.Length- pivot];
            Array.Copy(input, pivot, right_list, 0, input.Length- pivot);
            right_list = Merge_sort(right_list);

            return Merge(left_list, right_list);
        }

        public static int[] Merge(int[] left_list, int[] right_list)
        {
            int[] ret = new int[left_list.Length + right_list.Length];
            int left_cursor = 0, right_cursor = 0, ret_cursor = 0;

            while (left_cursor < left_list.Length &&
                   right_cursor < right_list.Length)
            {
                if (left_list[left_cursor] < right_list[right_cursor])
                {
                    ret[ret_cursor++] = left_list[left_cursor++];
                }
                else
                {
                    ret[ret_cursor++] = right_list[right_cursor++];
                }
            }
            // append what is remain the above lists
            while (left_cursor < left_list.Length)
            {
                ret[ret_cursor++] = left_list[left_cursor++];
            }
            while (right_cursor < right_list.Length)
            {
                ret[ret_cursor++] = right_list[right_cursor++];
            }
            return ret;
        }
    }
}
