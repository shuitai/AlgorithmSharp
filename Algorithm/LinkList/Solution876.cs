using Algorithm.Common;

namespace Algorithm.LinkList;

// https://leetcode.cn/problems/middle-of-the-linked-list/
// hint: use fast and slow pointer, fast move 2 step, slow move 1 step, when fast reach end, slow is middle
public class Solution876
{
    public ListNode MiddleNode(ListNode head)
    {
        var fast = head;
        var slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }
}