using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLinkListTailGenericNamespace
{
    //Step 1: create the node (Composite)
    //This class represent a node in LinkedList
    public class Node<AnyType>
    {
        public AnyType data;
        public Node<AnyType> next;
    }
    //Step 2: create simple linked list
    //This class will have a logic to connect the node object to create link list structure
    public class SimpleLinkListTailGeneric<AnyType>
    {
        //Step 3: create the head
        //This is start of the linked list chain
        Node<AnyType> head = null;
        Node<AnyType> tail = null;

        public void AddLast(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;
            //head, Tail --> newItem
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                //Performace: O(1)
                //current tails next item is set to new item
                //current tail set to new item
                tail.next = newItem;
                tail = newItem;
            }
        }
        public void AddFirst(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;
            if(head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                //This is now the first item, so the current head becomes the next item 
                newItem.next = head;
                //this new item become the head
                head = newItem;
            }

        }
        public void ReadAll()
        {
            Node<AnyType> current = head;
            //loop untill the last node
            //Display data in Link List
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
    }
}
