using System;
using System.Collections.Generic;

namespace Coding_AStack02
{
    class Usage_Stack
    {
        static void Main02()
        {
            // 1. Initialize a stack.
            Stack<int> stack = new Stack<int>();

            // 2. Push new element.
            stack.Push(5);
            stack.Push(13);
            stack.Push(8);
            stack.Push(6);

            // 3. Check if stack is empty.
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            // 4. Pop an element.
            stack.Pop();

            // 5. Get the top element.
            Console.WriteLine("The top element is: " + stack.Peek());

            // 6. Get the size of the stack.
            Console.WriteLine("The size is: " + stack.Count);

            //7. remove all elements
            //stack.Clear();

            //8. check element exists
            Console.WriteLine(stack.Contains(5));

            //9. copy elements to array
            int[] arr = new int[3];
            stack.CopyTo(arr, 0);

            //10. Check if equal
            Stack<int> stack2 = new Stack<int>();
            bool x = stack.Equals(stack2);

            //11. convert stack to array
            arr = stack.ToArray();

            //12. Iterate elements
            foreach(int s in stack)
                Console.WriteLine(s + " ");

            //Can't apply indexing to stack
            //for (int s = 0; s < stack.Count; s++)
            //    Console.WriteLine(stack[s] + " ");
        }
    }
}
