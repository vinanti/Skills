using System;
using System.Collections.Generic;

namespace Coding_AQueue02
{
    class Usage_Queue
    {
        static void Main01()
        {
            //1.Initialize
            Queue<int> queue = new Queue<int>();

            //2.Size
            Console.WriteLine("The size is: " + queue.Count);

            //3.Access 1st element
            //queue.Peek(); //through error (Queue empty) if queue id empty
            if (queue.Count > 0)
                Console.WriteLine("The first element is: " + queue.Peek());


            //4.Add element
            queue.Enqueue(5);
            queue.Enqueue(13);
            queue.Enqueue(8);
            queue.Enqueue(6);

            //5.Modify element
            //NA
            //Can't modify element once added into queue

            //6.Remove element
            queue.Dequeue();

            //7.Remove all elements
            //queue.Clear();

            //8.Check if element exists
            bool exists = queue.Contains(13);

            //9.Index of element
            //NA

            //10.Iterate elements
            foreach (int q in queue)
                Console.WriteLine(q + " ");

            //Can't apply indexing to queue
            //for (int q = 0; q < queue.Count; q++)
            //    Console.WriteLine(queue[q] + " ");

            //11.Convert to array
            int[] array = queue.ToArray();

            //12.Copy elements to array
            int[] array2 = new int[10];
            queue.CopyTo(array2, 3);

            //13.Sort
            //NA



            
        }
    }
}
