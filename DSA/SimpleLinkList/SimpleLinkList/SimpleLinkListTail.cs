using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLinkListTailNamespace
{
    //Exercise 1: Impmement Link List with tail to improve performace
    public class Node
    {
        public object data = null;
        public Node next = null;
    }
    public class SimpleLinkListTail
    {
        Node head = null;
        Node tail = null;

        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            //Step 1: First Item
            //head, Tail --> newItem
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                //Performace: O(1)
                //Step 2: current tails next item is set to new item
                //current tail set to new item
                tail.next = newItem;
                tail = newItem;
            }
        }

        internal void RemoveLast()
        {
            throw new NotImplementedException();
        }

        internal void RemoveInBetween(string v)
        {
            throw new NotImplementedException();
        }

        internal void RemoveFirst()
        {
            throw new NotImplementedException();
        }

        internal void AddInBetween(object data, object after)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if(head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }
        }
        public void ReadAll()
        {
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
    }
}
