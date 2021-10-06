using System;

namespace Coding_ALinkedList01_SinglyLinkedList
{
    // Definition for singly-linked list.
    public class SinglyListNode
    {
        public int val;
        public SinglyListNode next;
        public SinglyListNode(int x) { val = x; }
    }
    //1. Initiate a new linked list
    class MyLinkedList
    {
        private SinglyListNode head;
        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            head = null;
        }

        //2. Traverse the linked list to get element by index.
        /** Helper function to return the index-th node in the linked list. */
        private SinglyListNode GetNode(int index)
        {
            SinglyListNode cur = head;
            for (int i = 0; i < index && cur != null; ++i)
            {
                cur = cur.next;
            }
            return cur;
        }
        /** Helper function to return the last node in the linked list. */
        private SinglyListNode GetTail()
        {
            SinglyListNode cur = head;
            while (cur != null && cur.next != null)
            {
                cur = cur.next;
            }
            return cur;
        }
        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            SinglyListNode cur = GetNode(index);
            return cur == null ? -1 : cur.val;
        }

        //3. Add a new node.
        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            SinglyListNode cur = new SinglyListNode(val);
            cur.next = head;
            head = cur;
            return;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (head == null)
            {
                AddAtHead(val);
                return;
            }
            SinglyListNode prev = GetTail();
            SinglyListNode cur = new SinglyListNode(val);
            prev.next = cur;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }
            SinglyListNode prev = GetNode(index - 1);
            if (prev == null)
            {
                return;
            }
            SinglyListNode cur = new SinglyListNode(val);
            SinglyListNode next = prev.next;
            cur.next = next;
            prev.next = cur;
        }

        //5. Delete a node.
        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            SinglyListNode cur = GetNode(index);
            if (cur == null)
            {
                return;
            }
            SinglyListNode prev = GetNode(index - 1);
            SinglyListNode next = cur.next;
            if (prev != null)
            {
                prev.next = next;
            }
            else
            {
                // modify head when deleting the first node.
                head = next;
            }
        }
    }

    class Design_SinglyLinkedList
    {
        static void Main01()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
            myLinkedList.Get(1);              // return 2
            myLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
            myLinkedList.Get(1);              // return 3
        }
    }
}
