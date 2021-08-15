using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class Q901
    {
    }
    public class MinHeap
    {
        private static int capacity = 10;
        private int size = 0;
        int[] items = new int[capacity];

        private int GetLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
        private int GetRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
        private int GetParentIndex(int childIndex) { return (childIndex + 1) / 2; }

        private bool hasLeftChild(int index) { return GetLeftChildIndex(index) < size; }
        private bool hasRightChild(int index) { return GetRightChildIndex(index) < size; }
        private bool hasParent(int index) { return GetParentIndex(index) >= 0; }

        private int LeftChield(int index) { return items[GetLeftChildIndex(index)]; }
        private int RightChield(int index) { return items[GetRightChildIndex(index)]; }
        private int Parent(int index) { return items[GetParentIndex(index)]; }

        private void Swap(int indexOne, int indexTwo)
        {
            int temp = items[indexTwo];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }

        private void EnsureExtraCapacity()
        {
            if(size == capacity)
            {
                Array.Copy(items, items, capacity * 2);
                capacity *= 2;
            }
        }
    }
}
