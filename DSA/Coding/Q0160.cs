using System;
using System.Collections.Generic;

namespace Coding
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x, ListNode next = null) { val = x; this.next = next; }
    }

    public class Q0160
    {
        static void Main171()
        {
            ListNode headA = new ListNode(4, new ListNode(1, new ListNode(8, new ListNode(4, new ListNode(5)))));
            ListNode headB = new ListNode(5,new ListNode(6, new ListNode(1, new ListNode(8, new ListNode(4, new ListNode(5))))));
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            List<int> aList = GetAllNodes(headA);
            List<int> bList = GetAllNodes(headB);
            ListNode result = new ListNode(0);
            foreach (int a in aList)
            {
                result.next = headA;
                foreach (int b in bList)
                {
                    if (a == b) return result.next;
                    else result = result.next;
                }
            }
            return result;
        }
        public List<int> GetAllNodes(ListNode head)
        {
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            return list;
        }
    }
}
