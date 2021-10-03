using System;


namespace Coding_ALinkedList03
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        ListNode(int x) { val = x; }
    }

    class ALinkedList03_ReverseLinkedList
    {
        public ListNode reverseList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode currentHead = head;
            while (head.next != null)
            {
                ListNode p = head.next;
                head.next = p.next;
                p.next = currentHead;
                currentHead = p;
            }
            return currentHead;
        }
    }
}
