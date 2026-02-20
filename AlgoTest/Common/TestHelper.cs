using Algorithm.Common;

namespace AlgoTest.Common;

public static class TestHelper
{
    public static ListNode CreateList(int[] values)
    {
        if (values.Length == 0) return null;
        
        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        
        return head;
    }
    
    public static int[] ListToArray(ListNode head)
    {
        var result = new List<int>();
        var current = head;
        
        while (current != null)
        {
            result.Add(current.val);
            current = current.next;
        }
        
        return result.ToArray();
    }
}