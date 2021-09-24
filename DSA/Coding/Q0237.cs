using System;

namespace Coding_Q0237
{
    class Q0237
    {
        static void Main237()
        {
            ListNode list1 = new ListNode(4);
            ListNode list2 = new ListNode(5);
            ListNode list3 = new ListNode(1);
            ListNode list4 = new ListNode(9);
            list3.next = list4;
            list2.next = list3;
            list1.next = list2;
            DeleteNode(list2);
        }
        public static void DeleteNode(ListNode node)
        {
            ListNode nodeNext = node.next;
            node.val = nodeNext.val;
            node.next = nodeNext.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
