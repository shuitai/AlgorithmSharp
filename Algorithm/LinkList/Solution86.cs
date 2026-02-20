using Algorithm.Common;

namespace Algorithm.LinkList;

// https://leetcode.cn/problems/partition-list/description/
// hint: use two dummy node to store two part
public class Solution86
{
    public ListNode Partition(ListNode head, int x)
    {
        var dummy1 = new ListNode(-1);
        var dummy2 = new ListNode(-1);

        var p1 = dummy1;
        var p2 = dummy2;

        var p = head;

        while (p != null)
        {
            if (p.val < x)
            {
                p1.next = p;
                p1 = p1.next;
            }
            else
            {
                p2.next = p;
                p2 = p2.next;
            }

            var temp = p.next;
            p.next = null;
            p = temp;
        }
        
        // merge
        p1.next = dummy2.next;
        return dummy1.next;
    }
}