using Algorithm.DynamicProgram;

namespace AlgoTest;

public class Solution198Test
{
    private Solution198 _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new Solution198();
    }

    [Test]
    public void TestEmpty()
    {
        var result = _solution.Rob([]);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void TestSingle()
    {
        Assert.That(_solution.Rob([5]), Is.EqualTo(5));
    }

    [Test]
    public void TestTwo()
    {
        Assert.That(_solution.Rob([1, 2]), Is.EqualTo(2));
        Assert.That(_solution.Rob([2, 1]), Is.EqualTo(2));
    }

    [Test]
    public void TestExample1()
    {
        // [1,2,3,1] -> rob house 0 and 2 => 1 + 3 = 4
        Assert.That(_solution.Rob([1, 2, 3, 1]), Is.EqualTo(4));
    }

    [Test]
    public void TestExample2()
    {
        // [2,7,9,3,1] -> rob house 0,2,4 => 2 + 9 + 1 = 12
        Assert.That(_solution.Rob([2, 7, 9, 3, 1]), Is.EqualTo(12));
    }

    [Test]
    public void TestNoAdjacentBest()
    {
        // [2,1,1,2] -> rob house 0 and 3 => 2 + 2 = 4
        Assert.That(_solution.Rob([2, 1, 1, 2]), Is.EqualTo(4));
    }

    [Test]
    public void TestAllZeros()
    {
        Assert.That(_solution.Rob([0, 0, 0, 0]), Is.EqualTo(0));
    }
}
