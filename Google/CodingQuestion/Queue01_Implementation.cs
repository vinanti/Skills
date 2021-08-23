using System;
using System.Collections.Generic;
using System.Collections;

namespace CodingQuestion
{
    class Queue01_Implementation
    {
        static void Main01()
        {
            MyQueue q = new MyQueue();
            q.enQueue(5);
            q.enQueue(3);
            if (q.isEmpty() == false)
            {
                Console.WriteLine(q.Front());
            }
            q.deQueue();
            if (q.isEmpty() == false)
            {
                Console.WriteLine(q.Front());
            }
            q.deQueue();
            if (q.isEmpty() == false)
            {
                Console.WriteLine(q.Front());
            }
        }
    }

    class MyQueue
    {
        // store elements
        private List<int> data;
        // a pointer to indicate the start position
        private int p_start;
        public MyQueue()
        {
            data = new List<int>();
            p_start = 0;
        }
        /** Insert an element into the queue. Return true if the operation is successful. */
        public bool enQueue(int x)
        {
            data.Add(x);
            return true;
        }
        /** Delete an element from the queue. Return true if the operation is successful. */
        public bool deQueue()
        {
            if (isEmpty() == true)
            {
                return false;
            }
            p_start++;
            return true;
        }
        /** Get the front item from the queue. */
        public int Front()
        {
            return data[p_start];
        }
        /** Checks whether the queue is empty or not. */
        public bool isEmpty()
        {
            return p_start >= data.Count;
        }
    };
}
