using System;

namespace Coding_Q0203
{

    //Definition for singly-linked list.
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

    class Q0203
    {
        static void Main203()
        {
            ListNode list = new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
            RemoveElements(list, 6);
        }
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return head;
            ListNode sentinel = new ListNode(0);
            sentinel.next = head;

            ListNode prev = sentinel, curr = head;
            while (curr != null)
            {
                if (curr.val == val) prev.next = curr.next;
                else prev = curr;
                curr = curr.next;
            }
            return sentinel.next;
        }
    }
}
