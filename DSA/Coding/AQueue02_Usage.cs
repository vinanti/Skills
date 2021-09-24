using System;
using System.Collections.Generic;

namespace Coding
{
    class AQueue02_Usage
    {
        static void Main02()
        {
            // 1. Initialize a queue.
            Queue<int> q = new Queue<int>();

            // 2. Get the first element - return null if queue is empty.
            //q.Peek() through error (Queue empty) if queue id empty
            if (q.Count == 0)
                Console.WriteLine("Queue is empty");
            else
                Console.WriteLine("The first element is: " + q.Peek());

            // 3. Push new element.
            q.Enqueue(5);
            q.Enqueue(13);
            q.Enqueue(8);
            q.Enqueue(6);

            // 4. Pop an element.
            q.Dequeue();

            // 5. Get the first element.
            if (q.Count > 0)
                Console.WriteLine("The first element is: " + q.Peek());

            // 7. Get the size of the queue.
            Console.WriteLine("The size is: " + q.Count);
        }
    }
}
