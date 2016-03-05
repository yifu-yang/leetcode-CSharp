/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var temp=head;
        if(temp == null)
            return temp;
        while(temp != null)
        {
            if(temp.next!=null&&temp.val==temp.next.val)
            {
                temp.next=temp.next.next;   
            }else{
            temp=temp.next;}
        }
        return head;
    }
}