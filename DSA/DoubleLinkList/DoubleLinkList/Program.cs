using System;
using DoubleLinkListNamespace;

namespace DoubleLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkList<string> d = new DoubleLinkList<string>();

            d.AddLast("1");
            d.AddLast("2");

            d.ReadAll();
            d.ReadReverse();
            Console.ReadLine();
        }
    }
}
