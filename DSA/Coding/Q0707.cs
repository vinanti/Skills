using System;

namespace Coding
{
    class Q0707
    {
        static void Main()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
            int a = myLinkedList.Get(1);              // return 2
            myLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
            int b = myLinkedList.Get(1);              // return 3
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class MyLinkedList
    {
        int size;
        ListNode head; // sentinel node as pseudo-head

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            size = 0;
            head = new ListNode(0);
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            // if index is invalid
            if (index < 0 || index >= size) return -1;

            ListNode curr = head;
            // index steps needed 
            // to move from sentinel node to wanted index
            for (int i = 0; i < index + 1; ++i) curr = curr.next;
            return curr.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            AddAtIndex(size, val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            // If index is greater than the length, 
            // the node will not be inserted.
            if (index > size) return;

            // [so weird] If index is negative, 
            // the node will be inserted at the head of the list.
            if (index < 0) index = 0;

            ++size;
            // find predecessor of the node to be added
            ListNode pred = head;
            for (int i = 0; i < index; ++i) pred = pred.next;

            // node to be added
            ListNode toAdd = new ListNode(val);
            // insertion itself
            toAdd.next = pred.next;
            pred.next = toAdd;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            // if the index is invalid, do nothing
            if (index < 0 || index >= size) return;

            size--;
            // find predecessor of the node to be deleted
            ListNode pred = head;
            for (int i = 0; i < index; ++i) pred = pred.next;

            // delete pred.next
            pred.next = pred.next.next;
        }
    }
}
