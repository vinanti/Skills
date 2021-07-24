using System;
using NSBinaryTree;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> bst = new BinaryTree<int>();
            bst.Add(0);
            bst.Add(1);
            bst.Add(2);
            bst.Add(3);
            bst.Add(4);
            
            Console.Read();
        }
    }
}
