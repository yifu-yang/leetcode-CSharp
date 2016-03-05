/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode start;
        ListNode tmp1,tmp2;
        if(l1==null&&l2==null)
            return null;
        if(l1==null&&l2!=null)
            return l2;
        if(l1!=null&&l2==null)
            return l1;
        if(l1.val>l2.val){
            start=l2;
            tmp1=start;
            tmp2=l1;
        }
        else{
            start=l1;
            tmp1=start;
            tmp2=l2;
        }
        while(tmp1!=null&&tmp2!=null){
            if(tmp2.val>=tmp1.val){
                if(tmp1.next!=null){
                    if(tmp2.val<tmp1.next.val){
                ListNode tmp=new ListNode(tmp2.val);
                tmp.next=tmp1.next;
                tmp1.next=tmp;
                tmp2=tmp2.next;}
                else
                tmp1=tmp1.next;
                }
                else{
                    tmp1.next=tmp2;
                    break;
                }
            }
            else{
                tmp1=tmp1.next;
            }
        }
        return start;
    }
}