using System;

namespace Coding_Q1474
{
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
    class Q1474
    {
        static void Main1474()
        {
            ListNode list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8, new ListNode(9, new ListNode(10, new ListNode(11, new ListNode(12, new ListNode(13)))))))))))));
            DeleteNodes(list,2,3);
        }
        public static ListNode DeleteNodes(ListNode head, int m, int n)
        {
            ListNode current = head;
            while (current != null)
            {
                for (int i = 0; i < m-1; i++)
                {
                    if (current != null)
                        current = current.next;
                }
                if(current != null)
                    current.next = DeleteNodes(current.next, n);
                current = current.next;
            }
            return head;
        }
        public static ListNode DeleteNodes(ListNode head, int n)
        {
            while (head != null && n > 0)
            {
                head = head.next;
                n--;
            }
            return head;
        }
    }
}
