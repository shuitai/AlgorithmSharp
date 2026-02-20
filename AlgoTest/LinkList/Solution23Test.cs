using Algorithm.Common;
using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution23Test
{
    [Test]
    public void Test1_ExampleCase()
    {
        var solution = new Solution23();
        var lists = new ListNode[]
        {
            TestHelper.CreateList([1, 4, 5]),
            TestHelper.CreateList([1, 3, 4]),
            TestHelper.CreateList([2, 6])
        };
        var result = solution.MergeKLists(lists);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 1, 2, 3, 4, 4, 5, 6 }));
    }
    
    [Test]
    public void Test2_EmptyLists()
    {
        var solution = new Solution23();
        var lists = new ListNode[] { };
        var result = solution.MergeKLists(lists);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test3_AllNullLists()
    {
        var solution = new Solution23();
        var lists = new ListNode[] { null, null, null };
        var result = solution.MergeKLists(lists);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test4_SingleList()
    {
        var solution = new Solution23();
        var lists = new ListNode[] { TestHelper.CreateList([1, 2, 3]) };
        var result = solution.MergeKLists(lists);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3 }));
    }
    
    [Test]
    public void Test5_OneNullList()
    {
        var solution = new Solution23();
        var lists = new ListNode[] { TestHelper.CreateList([1, 2, 3]), null, TestHelper.CreateList([4, 5]) };
        var result = solution.MergeKLists(lists);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }));
    }
    
    [Test]
    public void Test6_SingleNodeLists()
    {
        var solution = new Solution23();
        var lists = new ListNode[]
        {
            TestHelper.CreateList([3]),
            TestHelper.CreateList([1]),
            TestHelper.CreateList([2]),
            TestHelper.CreateList([4])
        };
        var result = solution.MergeKLists(lists);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 4 }));
    }
    
    [Test]
    public void Test7_DuplicateValues()
    {
        var solution = new Solution23();
        var lists = new ListNode[]
        {
            TestHelper.CreateList([1, 1, 1]),
            TestHelper.CreateList([1, 1]),
            TestHelper.CreateList([1])
        };
        var result = solution.MergeKLists(lists);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 1, 1, 1, 1, 1 }));
    }
    
    [Test]
    public void Test8_VaryingLengths()
    {
        var solution = new Solution23();
        var lists = new ListNode[]
        {
            TestHelper.CreateList([1, 5, 9]),
            TestHelper.CreateList([2]),
            TestHelper.CreateList([3, 4, 6, 7, 8])
        };
        var result = solution.MergeKLists(lists);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
    }
    
    [Test]
    public void Test9_EmptyAndNonEmptyLists()
    {
        var solution = new Solution23();
        var lists = new ListNode[]
        {
            TestHelper.CreateList([1, 2]),
            null,
            TestHelper.CreateList([3]),
            null,
            TestHelper.CreateList([4, 5])
        };
        var result = solution.MergeKLists(lists);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }));
    }
}