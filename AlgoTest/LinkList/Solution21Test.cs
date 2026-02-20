using Algorithm.Common;
using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution21Test
{
    [Test]
    public void Test1_ExampleCase1()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([1, 2, 4]);
        var list2 = TestHelper.CreateList([1, 3, 4]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 1, 2, 3, 4, 4 }));
    }
    
    [Test]
    public void Test2_ExampleCase2()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([]);
        var list2 = TestHelper.CreateList([]);
        var result = solution.MergeTwoLists(list1, list2);
        
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Test3_ExampleCase3()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([]);
        var list2 = TestHelper.CreateList([0]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 0 }));
    }
    
    [Test]
    public void Test4_OneListEmpty()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([1, 3, 5]);
        var list2 = TestHelper.CreateList([]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 3, 5 }));
    }
    
    [Test]
    public void Test5_SecondListEmpty()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([]);
        var list2 = TestHelper.CreateList([2, 4, 6]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 2, 4, 6 }));
    }
    
    [Test]
    public void Test6_SingleNodeLists()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([1]);
        var list2 = TestHelper.CreateList([2]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2 }));
    }
    
    [Test]
    public void Test7_DuplicateValues()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([1, 1, 2]);
        var list2 = TestHelper.CreateList([1, 3, 3]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 1, 1, 2, 3, 3 }));
    }
    
    [Test]
    public void Test8_DifferentLengths()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([1, 2, 3, 4, 5]);
        var list2 = TestHelper.CreateList([6, 7]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6, 7 }));
    }
    
    [Test]
    public void Test9_AllValuesInFirstList()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([1, 2, 3]);
        var list2 = TestHelper.CreateList([4, 5, 6]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6 }));
    }
    
    [Test]
    public void Test10_AllValuesInSecondList()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([4, 5, 6]);
        var list2 = TestHelper.CreateList([1, 2, 3]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6 }));
    }
    
    [Test]
    public void Test11_NegativeValues()
    {
        var solution = new Solution21();
        var list1 = TestHelper.CreateList([-3, -1, 0]);
        var list2 = TestHelper.CreateList([-2, 1, 2]);
        var result = solution.MergeTwoLists(list1, list2);
        var resultArray = TestHelper.ListToArray(result);
        
        Assert.That(resultArray, Is.EqualTo(new[] { -3, -2, -1, 0, 1, 2 }));
    }
}