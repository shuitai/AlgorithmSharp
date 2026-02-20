using Algorithm.Common;

namespace Algorithm.LinkList;

// https://leetcode.com/problems/reverse-linked-list/
public class Solution206
{
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null)
        {
            return head;
        }
        
        ListNode? pre = null, cur, next;
        cur = head;
        next = head.next;
        while (cur != null)
        {
            cur.next = pre;
            pre = cur;
            cur = next;
            if (next != null)
            {
                next = next.next;
            }
        }

        return pre;
    }
}