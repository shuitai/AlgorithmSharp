using Algorithm.Common;
using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution141Test
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

    [Test]
    public void Test1_ExampleCase1()
    {
        var solution = new Solution141();
        var head = CreateListWithCycle([3, 2, 0, -4], 1);
        var result = solution.HasCycle(head);
        
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void Test2_ExampleCase2()
    {
        var solution = new Solution141();
        var head = CreateListWithCycle([1, 2], 0);
        var result = solution.HasCycle(head);
        
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void Test3_ExampleCase3()
    {
        var solution = new Solution141();
        var head = TestHelper.CreateList([1]);
        var result = solution.HasCycle(head);
        
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void Test4_EmptyList()
    {
        var solution = new Solution141();
        var result = solution.HasCycle(null);
        
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void Test5_SingleNodeCycle()
    {
        var solution = new Solution141();
        var head = CreateListWithCycle([1], 0);
        var result = solution.HasCycle(head);
        
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void Test6_NoCycleLongList()
    {
        var solution = new Solution141();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        var result = solution.HasCycle(head);
        
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void Test7_CycleAtEnd()
    {
        var solution = new Solution141();
        var head = CreateListWithCycle([1, 2, 3, 4, 5], 4);
        var result = solution.HasCycle(head);
        
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void Test8_CycleAtMiddle()
    {
        var solution = new Solution141();
        var head = CreateListWithCycle([1, 2, 3, 4, 5, 6, 7, 8], 3);
        var result = solution.HasCycle(head);
        
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void Test9_TwoNodesNoCycle()
    {
        var solution = new Solution141();
        var head = TestHelper.CreateList([1, 2]);
        var result = solution.HasCycle(head);
        
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void Test10_TwoNodesWithCycle()
    {
        var solution = new Solution141();
        var head = CreateListWithCycle([1, 2], 1);
        var result = solution.HasCycle(head);
        
        Assert.That(result, Is.True);
    }
}