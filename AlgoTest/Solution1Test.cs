using Algorithm;

namespace AlgoTest;

public class Solution1Test
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var solution = new Solution1();
        int[] nums = [2, 7, 11, 15];
        var target = 9;
        var result = solution.TwoSum(nums, target);
        Assert.That(result, Is.EqualTo(new[] { 0, 1 }));
        
        nums = [3, 4, 2];
        target = 6;
        result = solution.TwoSum(nums, target);
        Assert.That(result, Is.EqualTo(new[] { 1, 2 }));
        
        nums = [3, 3];
        target = 6;
        result = solution.TwoSum(nums, target);
        Assert.That(result, Is.EqualTo(new[] { 0, 1 }));
    }

    [Test]
    public void Test2()
    {
        var solution = new Solution1();
        int[] nums = [1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1];
        var target = 11;
        var result = solution.TwoSum(nums, target);
        Assert.That(result, Is.EqualTo(new[] { 5, 11 }));
    }
}