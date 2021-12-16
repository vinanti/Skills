using System;

namespace Coding_AQueue02_DesignCircularQueue
{
    class AQueue02_DesignCircularQueue
    {
        static void Main01()
        {
            MyCircularQueue myCircularQueue = new MyCircularQueue(3);
            myCircularQueue.EnQueue(1); // return True
            myCircularQueue.EnQueue(2); // return True
            myCircularQueue.EnQueue(3); // return True
            myCircularQueue.EnQueue(4); // return False
            myCircularQueue.Rear();     // return 3
            myCircularQueue.IsFull();   // return True
            myCircularQueue.DeQueue();  // return True
            myCircularQueue.EnQueue(4); // return True
            myCircularQueue.Rear();     // return 4
        }
    }
    public class MyCircularQueue
    {
        private int[] queue;
        private int headIndex;
        private int count;
        private int capacity;

        public MyCircularQueue(int k)
        {
            capacity = k;
            queue = new int[k];
            headIndex = 0;
            count = 0;
        }

        public bool EnQueue(int value)
        {
            if (count == capacity)
                return false;
            queue[(headIndex + count) % capacity] = value;
            count++;
            return true;
        }

        public bool DeQueue()
        {
            if (count == 0)
                return false;
            headIndex = (headIndex + 1) % capacity;
            count--;
            return true;
        }

        public int Front()
        {
            if (count == 0)
                return -1;
            return queue[headIndex];
        }

        public int Rear()
        {
            if (count == 0)
                return -1;
            int tailIndex = (headIndex + count - 1) % capacity;
            return queue[tailIndex];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public bool IsFull()
        {
            return (count == capacity);
        }
    }
}
