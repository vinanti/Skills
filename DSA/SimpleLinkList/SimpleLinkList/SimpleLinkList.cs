using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLinkListNamespace
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
    public class SimpleLinkList
    {
        //Step 3: create the head
        //This is start of the linked list chain
        Node head = null;

        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
            }
            else
            {
                //Performace: O(n)
                Node current = head;
                //loop and find the last node
                while (current.next != null)
                {
                    current = current.next;
                }
                //If null this means this is the last element
                current.next = newItem;
            }
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            //This is now the first item, so the current head becomes the next item 
            newItem.next = head;
            //this new item become the head
            head = newItem;
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
