using System;
using System.Collections.Generic;

namespace Coding
{
    class AStack01_DesignStack
    {
        static void Main01()
        {
            MyStack s = new MyStack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            for (int i = 0; i < 4; ++i)
            {
                if (!s.IsEmpty())
                {
                    Console.WriteLine(s.Top());
                }
                Console.WriteLine(s.Pop());
            }

            Stack<int> s1 = new Stack<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            for (int i = 0; i < 3; ++i)
            {
                if (s1.Count>0)
                {
                    Console.WriteLine(s1.Peek());
                }
                Console.WriteLine(s1.Pop());
            }
        }
    }
    
    class MyStack
    {
        private List<int> data;               // store elements
        public MyStack()
        {
            data = new List<int>();
        }
        /** Insert an element into the stack. */
        public void Push(int x)
        {
            data.Add(x);
        }
        /** Checks whether the queue is empty or not. */
        public bool IsEmpty()
        {
            return data.Count==0;
        }
        /** Get the top item from the queue. */
        public int Top()
        {
            return data[data.Count - 1];
        }
        /** Delete an element from the queue. Return true if the operation is successful. */
        public bool Pop()
        {
            if (IsEmpty())
            {
                return false;
            }
            data.RemoveAt(data.Count - 1);
            return true;
        }
    };
}
