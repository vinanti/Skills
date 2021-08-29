using System;
using System.Collections.Generic;
namespace CodingQuestion
{
    class MyQueue
    {
        private List<int> data;
        private int p_start;
        public MyQueue()
        {
            data = new List<int>();
            p_start = 0;
        }
        public bool enQueue(int x)
        {
            data.Add(x);
            return true;
        }
        public bool deQueue()
        {
            if (isEmpty() == true)
            {
                return false;
            }
            p_start++;
            return true;
        }
        public int Peek()
        {
            return data[p_start];
        }
        public bool isEmpty()
        {
            return p_start >= data.Count;
        }
    }
    class Queue01_Implementation
    {
        static void Main01()
        {
            MyQueue q = new MyQueue();
            q.enQueue(5);
            q.enQueue(3);
            if (q.isEmpty() == false)
            {
                Console.WriteLine(q.Peek());
            }
            q.deQueue();
            if (q.isEmpty() == false)
            {
                Console.WriteLine(q.Peek());
            }
            q.deQueue();
            if (q.isEmpty() == false)
            {
                Console.WriteLine(q.Peek());
            }
        }
    }
}
