using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkListNamespace
{
    //Step 1: create the node structure
    public class Node<T>
    {
        public T data;
        public Node<T> next = null;
        public Node<T> prev = null;
    }
    //Ste 2:
    public class DoubleLinkList<T>
    {
        public Node<T> Head = null;
        public Node<T> Tail = null;

        public void AddLast(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            if(Head == null)
            {
                Head = newItem;
                Tail = Head;
            }
            else
            {
                Tail.next = newItem;
                newItem.prev = Tail;
                Tail = newItem;
            }
        }

        //ReadAll
        //readReverse
        //Circular LinkList
    }
}
