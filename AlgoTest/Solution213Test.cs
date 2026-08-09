using Algorithm.DynamicProgram;

namespace AlgoTest;

public class Solution213Test
{
    private Solution213 _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new Solution213();
    }

    [Test]
    public void TestEmpty()
    {
        Assert.That(_solution.Rob([]), Is.EqualTo(0));
    }

    [Test]
    public void TestSingle()
    {
        Assert.That(_solution.Rob([5]), Is.EqualTo(5));
    }

    [Test]
    public void TestTwo()
    {
        // only one of two adjacent houses can be robbed
        Assert.That(_solution.Rob([1, 2]), Is.EqualTo(2));
        Assert.That(_solution.Rob([2, 1]), Is.EqualTo(2));
    }

    [Test]
    public void TestThree()
    {
        // [2,3,2]: can't rob both ends (2 and 2), best is 3
        Assert.That(_solution.Rob([2, 3, 2]), Is.EqualTo(3));
    }

    [Test]
    public void TestExample1()
    {
        // [2,3,2,3,3] -> rob 1 and 3 (3+3) or 0,2,4? 0+2+3=7... ends adjacent
        // best: 0,2,4 -> 2 + 2 + 3 = 7? but 0&4 adjacent -> invalid
        // best: 1,3 -> 3 + 3 = 6, or 0,2 -> 2+2=4, or 2,4 -> 2+3=5 => 6
        Assert.That(_solution.Rob([2, 3, 2, 3, 3]), Is.EqualTo(6));
    }

    [Test]
    public void TestExample2()
    {
        // [1,2,3,1] -> rob 1,3 => 2 + 1 = 3, or 0,2 => 1 + 3 = 4 => 4
        Assert.That(_solution.Rob([1, 2, 3, 1]), Is.EqualTo(4));
    }

    [Test]
    public void TestSkipFirstForBetter()
    {
        // [1, 5, 1, 1, 5]: ends adjacent (index 0 and 4), cannot rob both
        // best: skip first (index 0), rob index 1 and 4 => 5 + 5 = 10
        // (index 1 and 4 are not adjacent, and index 0 is left out so no wrap conflict)
        Assert.That(_solution.Rob([1, 5, 1, 1, 5]), Is.EqualTo(10));
    }

    [Test]
    public void TestAllZeros()
    {
        Assert.That(_solution.Rob([0, 0, 0, 0]), Is.EqualTo(0));
    }
}
