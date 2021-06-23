using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLinkListTailGenericNamespace
{
    //Exercise 1: Implemet link list by C# Generics
    public class Node<AnyType>
    {
        public AnyType data;
        public Node<AnyType> next;
    }
    public class SimpleLinkListTailGeneric<AnyType>
    {
        Node<AnyType> head = null;
        Node<AnyType> tail = null;

        public void AddLast(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
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
                newItem.next = head;
                head = newItem;
            }

        }
        public void RemoveItem(AnyType data)
        {
            Node<AnyType> current = head;
            Node<AnyType> privious = head;
            while (current != null)
            {
                if(EqualityComparer<AnyType>.Default.Equals(current.data, data))
                {
                    tail = current.next;
                    privious.next = tail;
                    break;
                }
                if (current != head)
                    privious = privious.next;
                current = current.next;
            }
        }
        public void ReadAll()
        {
            Node<AnyType> current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
    }
}
