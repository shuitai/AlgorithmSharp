using Algorithm.Array;

namespace AlgoTest.Array;

public class Solution26Test
{
    [Test]
    public void ExampleCase1_RemoveDuplicates()
    {
        var solution = new Solution26();
        var nums = new[] { 1, 1, 2 };
        var k = solution.RemoveDuplicates(nums);
        Assert.That(k, Is.EqualTo(2));
        Assert.That(nums[..k], Is.EqualTo(new[] { 1, 2 }));
    }

    [Test]
    public void ExampleCase2_MultipleDuplicates()
    {
        var solution = new Solution26();
        var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var k = solution.RemoveDuplicates(nums);
        Assert.That(k, Is.EqualTo(5));
        Assert.That(nums[..k], Is.EqualTo(new[] { 0, 1, 2, 3, 4 }));
    }

    [Test]
    public void NoDuplicates_ReturnsSameLength()
    {
        var solution = new Solution26();
        var nums = new[] { 1, 2, 3, 4 };
        var k = solution.RemoveDuplicates(nums);
        Assert.That(k, Is.EqualTo(4));
        Assert.That(nums[..k], Is.EqualTo(new[] { 1, 2, 3, 4 }));
    }

    [Test]
    public void AllSame_ReturnsSingleElement()
    {
        var solution = new Solution26();
        var nums = new[] { 5, 5, 5, 5 };
        var k = solution.RemoveDuplicates(nums);
        Assert.That(k, Is.EqualTo(1));
        Assert.That(nums[..k], Is.EqualTo(new[] { 5 }));
    }

    [Test]
    public void SingleElement_ReturnsOne()
    {
        var solution = new Solution26();
        var nums = new[] { 7 };
        var k = solution.RemoveDuplicates(nums);
        Assert.That(k, Is.EqualTo(1));
        Assert.That(nums[..k], Is.EqualTo(new[] { 7 }));
    }

    [Test]
    public void EmptyArray_ReturnsZero()
    {
        var solution = new Solution26();
        var k = solution.RemoveDuplicates([]);
        Assert.That(k, Is.EqualTo(0));
    }

    [Test]
    public void NullArray_ReturnsZero()
    {
        var solution = new Solution26();
        var k = solution.RemoveDuplicates(null);
        Assert.That(k, Is.EqualTo(0));
    }
}
