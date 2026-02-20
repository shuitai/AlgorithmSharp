using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution86Test
{
    [Test]
    public void Test1_ExampleCase()
    {
        var solution = new Solution86();
        var head = TestHelper.CreateList([1, 4, 3, 2, 5, 2]);
        var result = solution.Partition(head, 3);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 2, 4, 3, 5 }));
    }
    
    [Test]
    public void Test2_AllLessThanX()
    {
        var solution = new Solution86();
        var head = TestHelper.CreateList([1, 2, 3]);
        var result = solution.Partition(head, 5);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3 }));
    }
    
    [Test]
    public void Test3_AllGreaterOrEqualToX()
    {
        var solution = new Solution86();
        var head = TestHelper.CreateList([3, 4, 5]);
        var result = solution.Partition(head, 2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 3, 4, 5 }));
    }
    
    [Test]
    public void Test4_EmptyList()
    {
        var solution = new Solution86();
        var result = solution.Partition(null, 3);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test5_SingleNodeLessThanX()
    {
        var solution = new Solution86();
        var head = TestHelper.CreateList([1]);
        var result = solution.Partition(head, 3);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1 }));
    }
    
    [Test]
    public void Test6_SingleNodeGreaterOrEqualToX()
    {
        var solution = new Solution86();
        var head = TestHelper.CreateList([5]);
        var result = solution.Partition(head, 3);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 5 }));
    }
    
    [Test]
    public void Test7_AlreadyPartitioned()
    {
        var solution = new Solution86();
        var head = TestHelper.CreateList([1, 2, 3, 4]);
        var result = solution.Partition(head, 3);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 4 }));
    }
    
    [Test]
    public void Test8_ReverseOrder()
    {
        var solution = new Solution86();
        var head = TestHelper.CreateList([4, 3, 2, 1]);
        var result = solution.Partition(head, 3);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 2, 1, 4, 3 }));
    }
    
    [Test]
    public void Test9_DuplicateValues()
    {
        var solution = new Solution86();
        var head = TestHelper.CreateList([3, 3, 1, 1, 2, 2]);
        var result = solution.Partition(head, 2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 1, 3, 3, 2, 2 }));
    }
}