using Algorithm.Common;

namespace Algorithm.LinkList;

// https://leetcode.cn/problems/linked-list-cycle/
// hint: use fast and slow pointer, if they meet, there is a cycle
public class Solution141
{
    public bool HasCycle(ListNode head)
    {
        var fast = head;
        var slow = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }
}