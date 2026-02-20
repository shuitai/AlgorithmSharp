using Algorithm.Common;

namespace Algorithm.LinkList;

// https://leetcode.cn/problems/linked-list-cycle-ii/
// hint: 1. Detect cycle 2. Find the start of the cycle
public class Solution142
{
    public ListNode DetectCycle(ListNode head)
    {
        var slow = head;
        var fast = head;

        // Detect cycle
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                break;
            }
        }

        // no cycle
        if (fast == null || fast.next == null)
        {
            return null;
        }

        // Find the start of the cycle
        slow = head;
        while (slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }
        
        return slow;
    }
}