using Algorithm.Common;

namespace Algorithm.LinkList;

// https://leetcode.cn/problems/merge-k-sorted-lists/description/
public class Solution23
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var dummy = new ListNode(-1);
        var p = dummy;
        
        // min heap
        var pq = new PriorityQueue<ListNode, int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));

        // put head node in min heap
        foreach (var head in lists)
        {
            if (head == null) continue;
            pq.Enqueue(head, head.val);
        }

        while (pq.Count > 0)
        {
            // get min node from min heap
            var node = pq.Dequeue();
            p.next = node;
            if (node.next != null)
            {
                pq.Enqueue(node.next, node.next.val);
            }
            
            p = p.next;
        }

        return dummy.next;
    }
}