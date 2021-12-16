using System;
using System.Collections;
using System.Collections.Generic;

namespace Coding_AQueue01
{
    class AQueue01_DesignQueue
    {
        static void Main01()
        {
            MyQueue q = new MyQueue();
            q.EnQueue(5);
            q.EnQueue(3);
            if (q.IsEmpty() == false)
            {
                Console.WriteLine(q.Peek());
            }
            q.DeQueue();
            if (q.IsEmpty() == false)
            {
                Console.WriteLine(q.Peek());
            }
            q.DeQueue();
            if (q.IsEmpty() == false)
            {
                Console.WriteLine(q.Peek());
            }

            Queue q2 = new Queue();
            q2.Enqueue(5);
            q2.Enqueue(3);
            if (q2.Count > 0)
            {
                Console.WriteLine(q2.Peek());
            }
            q2.Dequeue();
            if (q2.Count > 0)
            {
                Console.WriteLine(q2.Peek());
            }
            q2.Dequeue();
            if (q2.Count>0)
            {
                Console.WriteLine(q2.Peek());
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
        public bool EnQueue(int x)
        {
            data.Add(x);
            return true;
        }
        /** Delete an element from the queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty() == true)
            {
                return false;
            }
            p_start++;
            return true;
        }
        /** Get the front item from the queue. */
        public int Peek()
        {
            return data[p_start];
        }
        /** Checks whether the queue is empty or not. */
        public bool IsEmpty()
        {
            return p_start >= data.Count;
        }
    };
}
