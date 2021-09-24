using System;

namespace Coding_Q0234
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
    class Q0234
    {
        static void Main234()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
            IsPalindrome(head);
        }
        public static bool IsPalindrome(ListNode head)
        {
            ListNode reverse = new ListNode(head.val);
            ListNode current = head.next;
            while (current != null)
            {
                ListNode temp = new ListNode();
                temp.val = current.val;
                temp.next = reverse;
                reverse = temp;
                current = current.next;
            }
            while(reverse != null)
            {
                if (head.val != reverse.val) return false;
                else
                {
                    head = head.next;
                    reverse = reverse.next;
                }
            }
            return true;
        }
    }
}
