/*Create a Binary Search tree*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q301ns
{
    class Q301
    {
        static void Main301(string[] args)
        {
            Node n = new Node(10);
            n.Insert(15);
            n.Insert(5);
            n.Insert(8);
            Console.WriteLine(n.Contains(8));
            Console.WriteLine("In Order Treversal");
            n.PrintInOrder();
            Console.WriteLine("Pre Order Treversal");
            n.PrintPreOrder();
            Console.WriteLine("Post Order Treversal");
            n.PrintPostOrder();
        }
    }
    class Node
    {
        Node left, right;
        int data;
        public Node(int data){
            this.data = data;
            }
        public int returnNode()
        {
            return data;
        }

        public void Insert(int value)
        {
            if(value <= data){
                if(left == null)
                    left = new Node(value);
                else 
                    left.Insert(value);
            } else {
                if(right == null)
                    right = new Node(value);
                else
                    right.Insert(value);
            }
        }

        public bool Contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            else if(value < data)
            {
                if(left==null)
                {
                    return false;
                } else
                {
                    return left.Contains(value);
                }
            }else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.Contains(value);
                }
            }
        }
        
        public void PrintInOrder()
        {
            if(left != null)
            {
                left.PrintInOrder();
            }
            Console.WriteLine(data);
            if(right != null)
            {
                right.PrintInOrder();
            }
        }

        public void PrintPreOrder()
        {
            Console.WriteLine(data);
            if (left != null)
            {
                left.PrintInOrder();
            }
            if (right != null)
            {
                right.PrintInOrder();
            }
        }

        public void PrintPostOrder()
        {
            if (left != null)
            {
                left.PrintInOrder();
            }
            if (right != null)
            {
                right.PrintInOrder();
            }
            Console.WriteLine(data);
        }
    }

}
