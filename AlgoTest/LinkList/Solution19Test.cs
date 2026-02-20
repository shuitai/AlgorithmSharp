using Algorithm.Common;
using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution19Test
{
    [Test]
    public void Test1_ExampleCase()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5]);
        var result = solution.RemoveNthFromEnd(head, 2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 5 }));
    }
    
    [Test]
    public void Test2_SingleNode()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1]);
        var result = solution.RemoveNthFromEnd(head, 1);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test3_RemoveFirstNode()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1, 2, 3]);
        var result = solution.RemoveNthFromEnd(head, 3);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 2, 3 }));
    }
    
    [Test]
    public void Test4_RemoveLastNode()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1, 2, 3]);
        var result = solution.RemoveNthFromEnd(head, 1);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2 }));
    }
    
    [Test]
    public void Test5_TwoNodesRemoveFirst()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1, 2]);
        var result = solution.RemoveNthFromEnd(head, 2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 2 }));
    }
    
    [Test]
    public void Test6_TwoNodesRemoveSecond()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1, 2]);
        var result = solution.RemoveNthFromEnd(head, 1);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1 }));
    }
    
    [Test]
    public void Test7_ThreeNodesRemoveMiddle()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1, 2, 3]);
        var result = solution.RemoveNthFromEnd(head, 2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 3 }));
    }
    
    [Test]
    public void Test8_FiveNodesRemoveThird()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5]);
        var result = solution.RemoveNthFromEnd(head, 3);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 4, 5 }));
    }
    
    [Test]
    public void Test9_TenNodesRemoveFifth()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        var result = solution.RemoveNthFromEnd(head, 5);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 4, 5, 7, 8, 9, 10 }));
    }
    
    [Test]
    public void Test10_DuplicateValues()
    {
        var solution = new Solution19();
        var head = TestHelper.CreateList([1, 1, 1, 1]);
        var result = solution.RemoveNthFromEnd(head, 2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 1, 1 }));
    }
}