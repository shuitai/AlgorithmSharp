using Algorithm.LinkList;
using AlgoTest.Common;

namespace AlgoTest.LinkList;

public class Solution83Test
{
    [Test]
    public void ExampleCase1_RemoveDuplicates()
    {
        var solution = new Solution83();
        var head = TestHelper.CreateList([1, 1, 2]);
        var result = solution.DeleteDuplicates(head);
        Assert.That(TestHelper.ListToArray(result), Is.EqualTo(new[] { 1, 2 }));
    }

    [Test]
    public void ExampleCase2_MultipleDuplicates()
    {
        var solution = new Solution83();
        var head = TestHelper.CreateList([1, 1, 2, 3, 3]);
        var result = solution.DeleteDuplicates(head);
        Assert.That(TestHelper.ListToArray(result), Is.EqualTo(new[] { 1, 2, 3 }));
    }

    [Test]
    public void NoDuplicates_ReturnsSame()
    {
        var solution = new Solution83();
        var head = TestHelper.CreateList([1, 2, 3]);
        var result = solution.DeleteDuplicates(head);
        Assert.That(TestHelper.ListToArray(result), Is.EqualTo(new[] { 1, 2, 3 }));
    }

    [Test]
    public void AllDuplicates_ReturnsSingleNode()
    {
        var solution = new Solution83();
        var head = TestHelper.CreateList([3, 3, 3]);
        var result = solution.DeleteDuplicates(head);
        Assert.That(TestHelper.ListToArray(result), Is.EqualTo(new[] { 3 }));
    }

    [Test]
    public void SingleNode_ReturnsItself()
    {
        var solution = new Solution83();
        var head = TestHelper.CreateList([1]);
        var result = solution.DeleteDuplicates(head);
        Assert.That(TestHelper.ListToArray(result), Is.EqualTo(new[] { 1 }));
    }

    [Test]
    public void NullInput_ReturnsNull()
    {
        var solution = new Solution83();
        var result = solution.DeleteDuplicates(null);
        Assert.That(result, Is.Null);
    }
}
