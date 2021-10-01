using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public class ARecursionII02_DivideNConquerQuickSort
    {
        static void Main02()
        {
            int[] input = new int[] { 1, 5, 3, 2, 8, 7, 6, 4 };
            QuickSort(input);
        }
        public static void QuickSort(int[] lst)
        {
            /* Sorts an array in the ascending order in O(n log n) time */
            int n = lst.Length;
            QSort(lst, 0, n - 1);
        }

        private static void QSort(int[] lst, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = Partition(lst, lo, hi);
                QSort(lst, lo, p - 1);
                QSort(lst, p + 1, hi);
            }
        }

        private static int Partition(int[] lst, int lo, int hi)
        {
            /*
              Picks the last element hi as a pivot
              and returns the index of pivot value in the sorted array */
            int pivot = lst[hi];
            int i = lo;
            int tmp;
            for (int j = lo; j < hi; ++j)
            {
                if (lst[j] < pivot)
                {
                    tmp = lst[i];
                    lst[i] = lst[j];
                    lst[j] = tmp;
                    i++;
                }
            }
            tmp = lst[i];
            lst[i] = lst[hi];
            lst[hi] = tmp;
            return i;
        }

    }
}
