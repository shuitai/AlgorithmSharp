using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution876Test
{
    [Test]
    public void Test1_ExampleCase1()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 3, 4, 5 }));
    }

    [Test]
    public void Test2_ExampleCase2()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5, 6]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 4, 5, 6 }));
    }

    [Test]
    public void Test3_SingleNode()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 1 }));
    }

    [Test]
    public void Test4_TwoNodes()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1, 2]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 2 }));
    }

    [Test]
    public void Test5_ThreeNodes()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1, 2, 3]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 2, 3 }));
    }

    [Test]
    public void Test6_FourNodes()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1, 2, 3, 4]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 3, 4 }));
    }

    [Test]
    public void Test7_SevenNodes()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5, 6, 7]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 4, 5, 6, 7 }));
    }

    [Test]
    public void Test8_EightNodes()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5, 6, 7, 8]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 5, 6, 7, 8 }));
    }

    [Test]
    public void Test9_TenNodes()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 6, 7, 8, 9, 10 }));
    }

    [Test]
    public void Test10_DuplicateValues()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([1, 1, 1, 1, 1]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { 1, 1, 1 }));
    }

    [Test]
    public void Test11_NegativeValues()
    {
        var solution = new Solution876();
        var head = TestHelper.CreateList([-3, -2, -1, 0, 1]);
        var result = solution.MiddleNode(head);
        var resultArray = TestHelper.ListToArray(result);

        Assert.That(resultArray, Is.EqualTo(new[] { -1, 0, 1 }));
    }
}