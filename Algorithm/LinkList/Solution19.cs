using Algorithm.Common;

namespace Algorithm.LinkList;

// https://leetcode.cn/problems/remove-nth-node-from-end-of-list/
// hint: use fast and slow pointer, fast move n step first, then move together
public class Solution19
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var p1 = head;

        for (int i = 0; i < n; i++)
        {
            p1 = p1.next;
        }

        var dummy = new ListNode(-1);
        dummy.next = head;
        
        var pre = dummy;
        var p2 = head;
        while (p1 != null)
        {
            p1 = p1.next;
            p2 = p2.next;
            pre = pre.next;
        }

        // delete p1
        pre.next = p2.next;
        return dummy.next;
    }
}