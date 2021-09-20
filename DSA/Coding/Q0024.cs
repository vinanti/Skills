using System;

namespace Coding_Q0024
{

 
 //Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
    public class Q0024
    {
        public static void Main24()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, null)));
            //ListNode head = new ListNode();
            SwapPairs(head);
        }
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode current = head;
            while (current != null)
            {
                if(current.next != null)
                {
                    int temp = current.val;
                    current.val = current.next.val;
                    current.next.val = temp;
                    current = current.next;
                }
                current = current.next;
            }
            return head;
        }
    }
}
