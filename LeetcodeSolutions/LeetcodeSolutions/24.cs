/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null)
            return head;
        bool IsHead = true;
        ListNode newhead = null;
        ListNode newtail = null;
        while (head != null)
        {
            if (head.next != null)
            {
                var tmp1 = head;
                var tmp2 = head.next;

                if (IsHead) { newhead = tmp2; IsHead = false; }
                else { newtail.next = tmp2; }
                tmp1.next = tmp2.next;
                tmp2.next = tmp1;
                newtail = tmp1;
                head = tmp1.next;
            }
            else
            {
                if (IsHead) { newhead = head; IsHead = false; }
                else { newtail = head; }
                head = head.next;
            }
        }
        return newhead;
    }
}