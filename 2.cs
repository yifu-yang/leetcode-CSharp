public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode item;
            if (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    if (l2.val < 10)
                    {
                        item = new ListNode(l2.val);
                        item.next = AddTwoNumbers(null, l2.next);
                        return item;
                    }
                    else
                    {
                        item = new ListNode(l2.val % 10);
                        item.next = AddTwoNumbers(new ListNode(l2.val / 10), l2.next);
                        return item;
                    }
                }
                else if (l2 == null)
                {
                    if (l1.val < 10)
                    {
                        item = new ListNode(l1.val);
                        item.next = AddTwoNumbers(null, l1.next);
                        return item;
                    }
                    else 
                    {
                        item = new ListNode(l1.val % 10);
                        item.next = AddTwoNumbers(new ListNode(l1.val / 10), l1.next);
                        return item;
                    }
                }
                else if (l1 != null && l2 != null)
                {
                    item = new ListNode((l1.val + l2.val) % 10);
                    if (l1.next != null)
                    {
                        l1.next.val += (l1.val + l2.val) / 10;
                        item.next = AddTwoNumbers(l1.next, l2.next);
                    }
                    else if (l2.next != null)
                    {
                        l2.next.val += (l1.val + l2.val) / 10;
                        item.next = AddTwoNumbers(l1.next, l2.next);
                    }
                    else if (l1.next == null && l2.next == null && ((l1.val + l2.val) >= 10))
                    {
                        var tmp = new ListNode((l1.val + l2.val) / 10);
                        item.next = AddTwoNumbers(tmp, null);
                    }
                    return item;
                }
                return null;
            }
            else
                return null;

        }
}