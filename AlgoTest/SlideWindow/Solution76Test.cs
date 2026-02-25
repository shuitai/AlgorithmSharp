using Algorithm.SlideWindow;

namespace AlgoTest.SlideWindow;

public class Solution76Test
{
    [Test]
    public void ExampleCase_MinWindowFound()
    {
        var solution = new Solution76();
        var result = solution.MinWindow("ADOBECODEBANC", "ABC");
        Assert.That(result, Is.EqualTo("BANC"));
    }

    [Test]
    public void DuplicateRequirement_ReturnsEntireString()
    {
        var solution = new Solution76();
        var result = solution.MinWindow("AA", "AA");
        Assert.That(result, Is.EqualTo("AA"));
    }

    [Test]
    public void MultipleCandidates_PicksSmallest()
    {
        var solution = new Solution76();
        var result = solution.MinWindow("aaflslflsldkalskaaa", "aaa");
        Assert.That(result, Is.EqualTo("aaa"));
    }

    [Test]
    public void NotPossible_ReturnsEmpty()
    {
        var solution = new Solution76();
        var result = solution.MinWindow("A", "AA");
        Assert.That(result, Is.EqualTo(string.Empty));
    }
}

