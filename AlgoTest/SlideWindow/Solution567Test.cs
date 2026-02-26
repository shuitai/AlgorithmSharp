using Algorithm.SlideWindow;

namespace AlgoTest.SlideWindow;

public class Solution567Test
{
    [Test]
    public void ExampleCase_PermutationExists()
    {
        var solution = new Solution567();
        var result = solution.CheckInclusion("ab", "eidbaooo");
        Assert.That(result, Is.True);
    }

    [Test]
    public void ExampleCase_PermutationMissing()
    {
        var solution = new Solution567();
        var result = solution.CheckInclusion("ab", "eidboaoo");
        Assert.That(result, Is.False);
    }

    [Test]
    public void DuplicateRequirement_FindsMatch()
    {
        var solution = new Solution567();
        var result = solution.CheckInclusion("aabc", "eidbaacoo");
        Assert.That(result, Is.True);
    }

    [Test]
    public void EmptyInput_ReturnsFalse()
    {
        var solution = new Solution567();
        var result = solution.CheckInclusion(string.Empty, "abc");
        Assert.That(result, Is.False);
    }
}

