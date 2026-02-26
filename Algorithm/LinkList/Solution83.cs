using Algorithm.Common;

namespace Algorithm.LinkList;

// https://leetcode.cn/problems/remove-duplicates-from-sorted-list/description/
public class Solution83
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
        {
            return head;
        }

        var slow = head;
        var fast = head;

        while (fast != null)
        {
            if (fast.val != slow.val)
            {
                slow.next = fast;
                slow = slow.next;
            }
            
            fast = fast.next;
        }

        slow.next = null;

        return head;
    }
}