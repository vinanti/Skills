using System;

namespace Coding_Q0002
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
    public class Q0002
    {
        static void Main02()
        {
            AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))));
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode current = result;
            int nextPlace = 0;
            while (l1 != null || l2 != null)
            {
                int num1 = 0, num2 = 0;
                if (l1 != null)
                {
                    num1 = l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    num2 = l2.val;
                    l2 = l2.next;
                }
                nextPlace += num1 + num2;
                current.next = new ListNode(nextPlace % 10);
                current = current.next;
                nextPlace /= 10;
            }
            if (nextPlace > 0)
            {
                ListNode temp = new ListNode(nextPlace);
                temp.next = result;
                result = temp;
            }
            return result.next;
        }
    }
}
