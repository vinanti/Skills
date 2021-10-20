using System;
using System.Collections.Generic;

namespace Coding_AStack02
{
    class Usage_Stack
    {
        static void Main02()
        {
            //1.Initialize
            Stack<int> stack = new Stack<int>();

            //2.Size
            Console.WriteLine("The size is: " + stack.Count);

            //3.Access 1st element
            //stack.Peek(); //through error (Queue empty) if queue id empty
            if (stack.Count > 0)
                Console.WriteLine("The top element is: " + stack.Peek());
            
            //4.Add element
            stack.Push(5);
            stack.Push(13);
            stack.Push(8);
            stack.Push(6);

            //5.Modify element
            //NA

            //6.Remove element
            stack.Pop();

            //7.Remove all elements
            //stack.Clear();

            //8.Check if element exists
            Console.WriteLine(stack.Contains(5));

            //9.Index of element
            //NA

            //10.Iterate elements
            foreach (int s in stack)
                Console.WriteLine(s + " ");

            //Can't apply indexing to stack
            //for (int s = 0; s < stack.Count; s++)
            //    Console.WriteLine(stack[s] + " ");

            //11.Convert to array
            int[] array = stack.ToArray();

            //12.Copy elements to array
            int[] array2 = new int[10];
            stack.CopyTo(array2, 1);

            //13.Sort
            //NA


       
        }
    }
}
