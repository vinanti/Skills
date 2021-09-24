using System;

namespace Coding_Q0206
{

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Q0206
    {
        static void Main206()
        {
            ListNode list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            ReverseList(list);
        }
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;
            ListNode current = head;
            ListNode reversed = null;
            while (current != null)
            {
                ListNode temp= new ListNode();
                temp.val = current.val;
                temp.next = reversed;
                reversed = temp;
                current = current.next;
            }
            return reversed;
        }
    }
}
