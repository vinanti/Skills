/* Queue Operations
 
 */

using System;
using System.Collections;

namespace Q8013
{
    class Q801
    {
        static void Main801()
        {
            Queue myQueue = new Queue();

            myQueue.Enqueue("FirstPerson");
            myQueue.Enqueue("SecondPerson");
            myQueue.Enqueue(1);

            var p1 = myQueue.Peek();
            var element1 = myQueue.Dequeue();

            var p2 = myQueue.Peek();
            var element2 = myQueue.Dequeue();

            var p3 = myQueue.Peek();
            var element3 = myQueue.Dequeue();

            int[] array = { 1, 2, 3, 4, 5 };
            Queue queue = new Queue(array);

            Console.WriteLine();

        }
    }
}
