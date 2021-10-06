using System;
using System.Collections.Generic;

namespace Coding_AQueue02
{
    class Usage_Queue
    {
        static void Main_01()
        {
            // 1. Initialize a queue.
            Queue<int> queue = new Queue<int>();

            // 2. Get the first element - return null if queue is empty.
            //q.Peek() through error (Queue empty) if queue id empty
            if (queue.Count == 0)
                Console.WriteLine("Queue is empty");
            else
                Console.WriteLine("The first element is: " + queue.Peek());

            // 3. Push new element.
            queue.Enqueue(5);
            queue.Enqueue(13);
            queue.Enqueue(8);
            queue.Enqueue(6);

            // 4. Pop an element.
            queue.Dequeue();

            // 5. Get the first element.
            if (queue.Count > 0)
                Console.WriteLine("The first element is: " + queue.Peek());

            // 7. Get the size of the queue.
            Console.WriteLine("The size is: " + queue.Count);

            //8. Clear the Queue
            queue.Clear();

            //9. Determine if emelemt contains in queue
            queue.Contains(5);

            //10. Copy Queue elements to an existing array
            int[] array = new int[10];
            queue.CopyTo(array, 3);

            //11. check if equal
            Queue<int> queue2 = new Queue<int>();
            queue.Equals(queue2);

            //12. Copy elements to new array
            array = queue.ToArray();

            //13. Iterate elements
            foreach (int q in queue)
                Console.WriteLine(q + " ");

            //Can't apply indexing to queue
            //for (int q = 0; q < queue.Count; q++)
            //    Console.WriteLine(queue[q] + " ");
        }
    }
}
