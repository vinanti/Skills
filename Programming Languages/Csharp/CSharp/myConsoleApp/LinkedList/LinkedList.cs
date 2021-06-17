using System;

namespace NSLinkedList
{
    //This class will have the logic
    //to connect the node objects to create
    //link list structure
    public class SimpleLinkedList
    {
        //start of the linked list chain
        Node head = null;
        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if(head == null)
            {
                head = newItem;
                head.next = null;
            }
            else
            {
                //loop and find the last node and add after it
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                //null this means this is the last element lat node
                current.next = newItem;
                newItem.next = null;
            }
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            //this is now the first item, so the current head become the next item
            newItem.next = head;
            //this newitem becomes the head
            head = newItem;
        }
        public void ReadAll()
        {
            Node current = head;
            //loop untill the last node
            //display the data inside it
            System.Console.WriteLine(current.data);
            while (current.next != null)
            {
                current = current.next;
                System.Console.WriteLine(current.data);
            }
        }
    }
}