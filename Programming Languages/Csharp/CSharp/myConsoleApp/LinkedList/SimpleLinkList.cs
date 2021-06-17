using System;
using NSLinkedList;

namespace myConsoleApp
{
    class Programsll
    {
        static void Mainsll(string[] args)
        {
            SimpleLinkedList lnk = new SimpleLinkedList(); 
            lnk.AddLast("One");
            lnk.AddLast("Two");
            lnk.AddLast("3");
            lnk.AddLast("4");
            lnk.AddFirst("First");
            lnk.ReadAll();
        }
    }
}
