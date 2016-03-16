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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        List<int> vals = new List<int>();
        while (head != null)
        {
            vals.Add(head.val);
            head = head.next;
        }
        vals.RemoveAt(vals.Count - n);

        var pre = head;
        for (int i = 0; i < vals.Count; i++)
        {
            var tmp = new ListNode(vals[i]);
            if (i == 0)
            {
                head = tmp;
                pre = tmp;
            }
            else {
                pre.next = tmp;
                pre = pre.next;
            }
        }
        return head;
    }
}