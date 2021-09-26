using System;
using System.Collections.Generic;

namespace Coding_AStack02
{
    class AStack02_Usage
    {
        static void Main02()
        {
            // 1. Initialize a stack.
            Stack<int> s = new Stack<int>();

            // 2. Push new element.
            s.Push(5);
            s.Push(13);
            s.Push(8);
            s.Push(6);

            // 3. Check if stack is empty.
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            // 4. Pop an element.
            s.Pop();

            // 5. Get the top element.
            Console.WriteLine("The top element is: " + s.Peek());

            // 6. Get the size of the stack.
            Console.WriteLine("The size is: " + s.Count);
        }
    }
}
