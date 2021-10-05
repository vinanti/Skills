using System;
using System.Collections.Generic;

namespace Coding_Q0023
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

    public class Q0023
    {
        static void Main23()
        {
            ListNode l1 = new ListNode(1, new ListNode(4, new ListNode(5)));
            ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode l3 = new ListNode(2, new ListNode(6));
            MergeKLists(new ListNode[] { l1, l2, l3 });
        }
        public static ListNode MergeKLists(ListNode[] lists)
        {
            ListNode result = null;
            foreach (ListNode l in lists)
            {
                if (result == null) result = l;
                else result = MergeList(result, l);
            }
            return result;
        }
        public static ListNode MergeList(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();
            ListNode current = result;
            while (list1 != null || list2 != null)
            {
                ListNode temp = new ListNode();
                if (list1 != null && list2 != null)
                {
                    if (list1.val < list2.val)
                    {
                        temp.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        temp.next = list2;
                        list2 = list2.next;
                    }
                }
                else if (list1 != null)
                {
                    temp.next = list1;
                    list1 = list1.next;
                }
                else if (list2 != null)
                {
                    temp.next = list2;
                    list2 = list2.next;
                }
                temp = temp.next;
                temp.next = null;
                current.next = temp;
                current = current.next;
            }
            return result.next;
        }
    }
}
