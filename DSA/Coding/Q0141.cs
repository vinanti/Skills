using System;
using System.Collections.Generic;

namespace Coding_Q0141
{

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Q0141
    {
        static void Main141()
        {
            ListNode list3 = new ListNode(3);
            ListNode list2 = new ListNode(2);
            list3.next = list2;
            ListNode list0 = new ListNode(0);
            list2.next = list0;
            ListNode list4 = new ListNode(-4);
            list0.next = list4;
            list4.next = list2;
            HasCycle(list3);

            ListNode list1 = new ListNode(1);
            ListNode list22 = new ListNode(2);
            list1.next = list22;
            HasCycle(list1);

            ListNode list11 = new ListNode(1);
            HasCycle(list11);
        }
        public static bool HasCycle(ListNode head)
        {
            ListNode current = head;
            bool flag = false;
            while (!flag && current != null)
            {
                ListNode currentNext = current.next;
                HashSet<int> nodeList = new HashSet<int>();
                while (!flag && currentNext != null)
                {
                    if (current.next == currentNext.next) {
                        flag = true;
                        break;
                    } 
                    else {
                        if (nodeList.Contains(currentNext.val)) break;
                        else nodeList.Add(currentNext.val);
                    }
                    currentNext = currentNext.next;
                }
                if (flag) break;
                else current = current.next;
            }
            return flag;
        }
    }
}
