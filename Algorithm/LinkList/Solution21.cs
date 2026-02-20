using Algorithm.Common;

namespace Algorithm.LinkList;

// https://leetcode.cn/problems/merge-two-sorted-lists/
public class Solution21
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode(-1);
        var p = dummy;

        var p1 = list1;
        var p2 = list2;
        while (p1 != null && p2 != null)
        {
            if (p1.val < p2.val)
            {
                p.next = p1;
                p1 = p1.next;
            }
            else
            {
                p.next = p2;
                p2 = p2.next;
            }

            p = p.next;
        }

        if (p1 != null)
        {
            p.next = p1;
        }

        if (p2 != null)
        {
            p.next = p2;
        }

        return dummy.next;
    }
}