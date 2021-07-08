using System;
using SimpleLinkListNamespace;
using SimpleLinkListTailNamespace;
using SimpleLinkListTailGenericNamespace;

namespace Program
{
    class myProgram
    {
        static void Main(string[] args)
        {
            SimpleLinkList lnk1 = new SimpleLinkList();
            lnk1.AddLast("One");
            lnk1.AddLast("Two");
            lnk1.AddLast("3");
            lnk1.AddLast("4");
            lnk1.AddFirst("First");
            lnk1.AddInBetween("3.5", "3");
            lnk1.ReadAll();


            SimpleLinkListTail lnk2 = new SimpleLinkListTail();
            lnk2.AddLast("One");
            lnk2.AddLast("Two");
            lnk2.AddLast("3");
            lnk2.AddLast("4");
            lnk2.AddFirst("First");
            lnk2.ReadAll();
         
            SimpleLinkListTailGeneric<int> lnk = new SimpleLinkListTailGeneric<int>();
            lnk.AddLast(1);
            lnk.AddLast(2);
            lnk.AddLast(3);
            lnk.AddLast(4);
            lnk.AddFirst(0);
            lnk.ReadAll();
            lnk.RemoveItem(2);
            Console.WriteLine("After Remove 3");
            lnk.ReadAll();
            Console.Read();
        }
    }
}
