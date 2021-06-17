using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLinkListTailNamespace
{
    //Step 1: create the node (Composite)
    //This class represent a node in LinkedList
    public class Node
    {
        public object data = null;
        public Node next = null;
    }
    //Step 2: create simple linked list
    //This class will have a logic to connect the node object to create link list structure
    public class SimpleLinkListTail
    {
        //Step 3: create the head
        //This is start of the linked list chain
        Node head = null;
        Node tail = null;

        public void AddLast(object data)
        {
            Node newItem = new Node();
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
                //This is now the first item, so the current head becomes the next item 
                newItem.next = head;
                //this new item become the head
                head = newItem;
            }

        }
        public void ReadAll()
        {
            Node current = head;
            //loop untill the last node
            //Display data in Link List
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }

        //Node tail = null;
        //public void Add(Object data)
        //{
        //    Node newItem = new Node();
        //    newItem.data = data;
        //    //Step 4: if this is the first element
        //    if(head == null)
        //    {
        //        //O(1)
        //        head = newItem;
        //    }
        //    else
        //    {
        //        //Step: you already have some nodes
        //        //loop till you find that next is null
        //        //Complexcity - O(n)
        //        //Q. How I can make this O(n) to O(1)?
        //        //If I have tail then this become O(1), because I can diretly add last elemt to tail
        //        //Q. How to get the tail or reach to tail to add last element
        //        //While adding elemts into the link list at that time we decide the tail
        //        Node current = head;
        //        while(current.nextNode != null)
        //        {
        //            current = current.nextNode;
        //        }
        //        current.nextNode = newItem;
        //        newItem.nextNode = null;
        //    }
        //}

        //public void AddFirst(object data)
        //{
        //    Node newItem = new Node();
        //    newItem.data = data;
        //    newItem.nextNode = head;
        //    head = newItem;
        //}

        //public void ReadAll()
        //{
        //    Node current = head;
        //    while(current.nextNode != null)
        //    {
        //        Console.WriteLine(current.data);
        //        current = current.nextNode;
        //    }
        //    Console.WriteLine(current.data);
        //}
    }
}
