/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        var tail = new ListNode(-1);
            ListNode tmp = new ListNode(-1);
            int count = 0;

            tmp = head;
            if (tmp == null) return head;

            while (tmp != null)
            {
                count++;
                if (tmp.next == null) tail = tmp;
                tmp = tmp.next;
            }
            if (count == 1) return head;

            int realK =k % count;
            if (realK == 0) return head;
            ListNode newhead, newend;
            tmp = head;
            for (int i = 0; i < count - realK - 1; i++)
            {
                tmp = tmp.next;
            }
            newhead = tmp.next;
            newend = tmp;
            newend.next = null;
            tmp = newhead;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            tmp.next = head;
            return newhead;
    }
}
