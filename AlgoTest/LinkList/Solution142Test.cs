using Algorithm.Common;
using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution142Test
{
    private ListNode CreateListWithCycle(int[] values, int cycleStartIndex)
    {
        if (values.Length == 0) return null;
        
        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        ListNode cycleStartNode = null;
        
        if (cycleStartIndex == 0)
        {
            cycleStartNode = head;
        }
        
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
            
            if (i == cycleStartIndex)
            {
                cycleStartNode = current;
            }
        }
        
        // Create the cycle
        if (cycleStartNode != null)
        {
            current.next = cycleStartNode;
        }
        
        return head;
    }
    
    private bool IsCycleStart(ListNode head, ListNode cycleStart)
    {
        if (cycleStart == null) return false;
        
        // Check if cycleStart is actually in a cycle
        var slow = cycleStart;
        var fast = cycleStart;
        
        bool hasCycle = false;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast)
            {
                hasCycle = true;
                break;
            }
        }
        
        if (!hasCycle) return false;
        
        // Check if cycleStart is the first node in the cycle
        // by traversing from head and seeing if we encounter cycleStart
        // before encountering any node in the cycle twice
        var current = head;
        var visitedNodes = new System.Collections.Generic.HashSet<ListNode>();
        
        while (current != null)
        {
            if (visitedNodes.Contains(current))
            {
                // We're back in the cycle, so the first node we encountered
                // in the cycle is the start
                return current == cycleStart;
            }
            
            if (current == cycleStart)
            {
                return true;
            }
            
            visitedNodes.Add(current);
            current = current.next;
        }
        
        return false;
    }

    [Test]
    public void Test1_ExampleCase1()
    {
        var solution = new Solution142();
        var head = CreateListWithCycle([3, 2, 0, -4], 1);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Not.Null);
        Assert.That(result.val, Is.EqualTo(2));
        Assert.That(IsCycleStart(head, result), Is.True);
    }
    
    [Test]
    public void Test2_ExampleCase2()
    {
        var solution = new Solution142();
        var head = CreateListWithCycle([1, 2], 0);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Not.Null);
        Assert.That(result.val, Is.EqualTo(1));
        Assert.That(IsCycleStart(head, result), Is.True);
    }
    
    [Test]
    public void Test3_ExampleCase3()
    {
        var solution = new Solution142();
        var head = TestHelper.CreateList([1]);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test4_EmptyList()
    {
        var solution = new Solution142();
        var result = solution.DetectCycle(null);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test5_SingleNodeCycle()
    {
        var solution = new Solution142();
        var head = CreateListWithCycle([1], 0);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Not.Null);
        Assert.That(result.val, Is.EqualTo(1));
        Assert.That(IsCycleStart(head, result), Is.True);
    }
    
    [Test]
    public void Test6_NoCycleLongList()
    {
        var solution = new Solution142();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test7_CycleAtEnd()
    {
        var solution = new Solution142();
        var head = CreateListWithCycle([1, 2, 3, 4, 5], 4);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Not.Null);
        Assert.That(result.val, Is.EqualTo(5));
        Assert.That(IsCycleStart(head, result), Is.True);
    }
    
    [Test]
    public void Test8_CycleAtMiddle()
    {
        var solution = new Solution142();
        var head = CreateListWithCycle([1, 2, 3, 4, 5, 6, 7, 8], 3);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Not.Null);
        Assert.That(result.val, Is.EqualTo(4));
        Assert.That(IsCycleStart(head, result), Is.True);
    }
    
    [Test]
    public void Test9_TwoNodesNoCycle()
    {
        var solution = new Solution142();
        var head = TestHelper.CreateList([1, 2]);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test10_TwoNodesWithCycle()
    {
        var solution = new Solution142();
        var head = CreateListWithCycle([1, 2], 1);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Not.Null);
        Assert.That(result.val, Is.EqualTo(2));
        Assert.That(IsCycleStart(head, result), Is.True);
    }
    
    [Test]
    public void Test11_LargeCycle()
    {
        var solution = new Solution142();
        var head = CreateListWithCycle([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 2);
        var result = solution.DetectCycle(head);
        
        Assert.That(result, Is.Not.Null);
        Assert.That(result.val, Is.EqualTo(3));
        Assert.That(IsCycleStart(head, result), Is.True);
    }
}