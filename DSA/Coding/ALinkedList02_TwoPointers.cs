using System;


namespace Coding_ALinkedList02
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x, ListNode next = null) { val = x; this.next = next; }
    }
    class ALinkedList02_TwoPointers
    {
        private ListNode head;
        static void Main()
        {

        }
        public bool TwoPointer()
        {
            // Initialize slow & fast pointers
            ListNode slow = head;
            ListNode fast = head;
            /**
             * Change this condition to fit specific problem.
             * Attention: remember to avoid null-pointer error
             **/
            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;           // move slow pointer one step each time
                fast = fast.next.next;      // move fast pointer two steps each time
                if (slow == fast)
                {         // change this condition to fit specific problem
                    return true;
                }
            }
            return false;   // change return value to fit specific problem
        }
    }
}
