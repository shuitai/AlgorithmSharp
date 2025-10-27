namespace Algorithm;

// https://leetcode.cn/problems/add-two-numbers/description/
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var head = new ListNode();
        var current = head;
        var isCarry = 0;
        
        while (l1 != null || l2 != null)
        {
            var newValue = 0;
            if (l1 == null)
            {
                newValue = (l2.val + isCarry) % 10;
                isCarry = (l2.val + isCarry) / 10;
                
                l2 = l2.next;
            }
            else if (l2 == null)
            {
                newValue = (l1.val + isCarry) % 10;
                isCarry = (l1.val + isCarry) / 10;
                
                l1 = l1.next;
            }
            else
            {
                newValue = (l1.val + l2.val + isCarry) % 10;
                isCarry = (l1.val + l2.val + isCarry) / 10;
                
                l1 = l1.next;
                l2 = l2.next;
            }
            current.next = new ListNode(newValue);
            current = current.next;
        }
        
        if (isCarry > 0)
        {
            current.next = new ListNode(isCarry);
        }

        return head.next;
    }
}