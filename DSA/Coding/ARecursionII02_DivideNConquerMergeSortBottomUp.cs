using System;

namespace Coding_ARecursionII02
{
    class ARecursionII02_DivideNConquerMergeSortBottomUp
    {
        static void Main02()
        {
            int[] input = new int[] { 1, 5, 3, 2, 8, 7, 6, 4 };
            Mergesort(input);

        }
        // Merge two sorted subarrays `A[from…mid]` and `A[mid+1…to]`
        public static void Merge(int[] A, int[] temp, int from, int mid, int to)
        {
            int k = from, i = from, j = mid + 1;

            // loop till no elements are left in the left and right runs
            while (i <= mid && j <= to)
            {
                if (A[i] < A[j])
                {
                    temp[k++] = A[i++];
                }
                else
                {
                    temp[k++] = A[j++];
                }
            }

            // copy remaining elements
            while (i <= mid)
            {
                temp[k++] = A[i++];
            }

            /* no need to copy the second half (since the remaining items
               are already in their correct position in the temporary array) */

            // copy back to the original array to reflect sorted order
            for (i = from; i <= to; i++)
            {
                A[i] = temp[i];
            }
        }

        // Iteratively sort subarray `A[low…high]` using a temporary array
        public static void Mergesort(int[] A)
        {
            int low = 0;
            int high = A.Length - 1;

            int[] temp = new int[A.Length];
            Array.Copy(A, temp, A.Length);

            for (int m = 1; m <= high - low; m = 2 * m)
            {
                for (int i = low; i < high; i += 2 * m)
                {
                    int from = i;
                    int mid = i + m - 1;
                    int to = Math.Min(i + 2 * m - 1, high);

                    Merge(A, temp, from, mid, to);
                }
            }
        }
    }
}
