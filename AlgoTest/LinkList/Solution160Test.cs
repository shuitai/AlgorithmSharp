using Algorithm.Common;
using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution160Test
{
    private (ListNode? headA, ListNode? headB, ListNode? intersection) CreateIntersectingLists(
        int[] valuesA, int[] valuesB, int[] commonValues)
    {
        // Create the common part of the lists
        ListNode? commonHead = null;
        if (commonValues.Length > 0)
        {
            commonHead = TestHelper.CreateList(commonValues);
        }
        
        // Create list A and connect it to the common part
        ListNode? headA = null;
        if (valuesA.Length > 0)
        {
            headA = TestHelper.CreateList(valuesA);
            // Find the last node of list A
            var lastA = headA;
            while (lastA.next != null)
            {
                lastA = lastA.next;
            }
            // Connect to common part
            lastA.next = commonHead;
        }
        else
        {
            headA = commonHead;
        }
        
        // Create list B and connect it to the common part
        ListNode? headB = null;
        if (valuesB.Length > 0)
        {
            headB = TestHelper.CreateList(valuesB);
            // Find the last node of list B
            var lastB = headB;
            while (lastB.next != null)
            {
                lastB = lastB.next;
            }
            // Connect to common part
            lastB.next = commonHead;
        }
        else
        {
            headB = commonHead;
        }
        
        return (headA, headB, commonHead);
    }

    [Test]
    public void Test1_ExampleCase1()
    {
        var solution = new Solution160();
        var (headA, headB, intersection) = CreateIntersectingLists([4, 1], [5, 6, 1], [8, 4, 5]);
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.EqualTo(intersection));
    }
    
    [Test]
    public void Test2_ExampleCase2()
    {
        var solution = new Solution160();
        var (headA, headB, intersection) = CreateIntersectingLists([1, 9, 1], [3], [2, 4]);
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.EqualTo(intersection));
    }
    
    [Test]
    public void Test3_ExampleCase3()
    {
        var solution = new Solution160();
        var (headA, headB, intersection) = CreateIntersectingLists([2, 6, 4], [1, 5], []);
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test4_NoIntersection()
    {
        var solution = new Solution160();
        var headA = TestHelper.CreateList([1, 2, 3]);
        var headB = TestHelper.CreateList([4, 5, 6]);
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test5_OneEmptyList()
    {
        var solution = new Solution160();
        var headA = TestHelper.CreateList([1, 2, 3]);
        ListNode? headB = null;
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test6_BothEmptyLists()
    {
        var solution = new Solution160();
        ListNode? headA = null;
        ListNode? headB = null;
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test7_IntersectionAtFirstNode()
    {
        var solution = new Solution160();
        var (headA, headB, intersection) = CreateIntersectingLists([], [], [1, 2, 3]);
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.EqualTo(intersection));
    }
    
    [Test]
    public void Test8_IntersectionAtLastNode()
    {
        var solution = new Solution160();
        var (headA, headB, intersection) = CreateIntersectingLists([1, 2], [3, 4], [5]);
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.EqualTo(intersection));
    }
    
    [Test]
    public void Test9_SingleNodeIntersection()
    {
        var solution = new Solution160();
        var (headA, headB, intersection) = CreateIntersectingLists([1], [2], [3]);
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.EqualTo(intersection));
    }
    
    [Test]
    public void Test10_SameList()
    {
        var solution = new Solution160();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5]);
        var result = solution.GetIntersectionNode(head, head);
        
        Assert.That(result, Is.EqualTo(head));
    }
    
    [Test]
    public void Test11_DifferentLengths()
    {
        var solution = new Solution160();
        var (headA, headB, intersection) = CreateIntersectingLists([1, 2, 3, 4, 5], [6, 7], [8, 9, 10]);
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.EqualTo(intersection));
    }
    
    [Test]
    public void Test12_OneListWithIntersectionOtherEmpty()
    {
        var solution = new Solution160();
        var (headA, headB, intersection) = CreateIntersectingLists([1, 2, 3], [], [4, 5]);
        var result = solution.GetIntersectionNode(headA, headB);
        
        Assert.That(result, Is.EqualTo(intersection));
    }
}