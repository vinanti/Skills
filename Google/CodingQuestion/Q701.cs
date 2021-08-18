/*LinkedList Operations*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingQuestion
{
    class Q701
    {
        static void Main701()
        {

            LinkedList<string> myList = new LinkedList<string>();
            myList.AddLast("AAA");
            myList.AddLast("BBB");
            myList.AddLast("CCC");
            myList.AddLast("AAA");
            myList.AddFirst("1111");
            myList.AddLast("AAA");
            LinkedListNode<string> node = myList.Find("BBB");

            myList.AddAfter(node, "BBB-2");

            myList.RemoveFirst();

            Console.WriteLine("Count: "+myList.Count());

            int foundAAAs = myList.Count(s => s == "AAA");
            Console.WriteLine("AAA count: "+foundAAAs);

            foreach (var x in myList)
                Console.WriteLine(x);
        }
    }
}
