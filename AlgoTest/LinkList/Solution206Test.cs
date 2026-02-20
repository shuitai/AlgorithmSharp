using Algorithm.Common;
using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution206Test
{
    [Test]
    public void Test1_ExampleCase1()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 5, 4, 3, 2, 1 }));
    }
    
    [Test]
    public void Test2_ExampleCase2()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([1, 2]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 2, 1 }));
    }
    
    [Test]
    public void Test3_ExampleCase3()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([]);
        var result = solution.ReverseList(head);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test4_SingleNode()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([1]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1 }));
    }
    
    [Test]
    public void Test5_ThreeNodes()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([1, 2, 3]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 3, 2, 1 }));
    }
    
    [Test]
    public void Test6_FourNodes()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([1, 2, 3, 4]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 4, 3, 2, 1 }));
    }
    
    [Test]
    public void Test7_SixNodes()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5, 6]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 6, 5, 4, 3, 2, 1 }));
    }
    
    [Test]
    public void Test8_NegativeValues()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([-1, -2, -3]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { -3, -2, -1 }));
    }
    
    [Test]
    public void Test9_MixedValues()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([0, 5, -3, 8, -2]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { -2, 8, -3, 5, 0 }));
    }
    
    [Test]
    public void Test10_DuplicateValues()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([1, 1, 2, 2, 3, 3]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 3, 3, 2, 2, 1, 1 }));
    }
    
    [Test]
    public void Test11_LargeList()
    {
        var solution = new Solution206();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        var result = solution.ReverseList(head);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
    }
}