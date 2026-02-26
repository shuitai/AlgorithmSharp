using Algorithm.SlideWindow;

namespace AlgoTest.SlideWindow;

public class Solution438Test
{
    [Test]
    public void ExampleCase1_TwoAnagrams()
    {
        var solution = new Solution438();
        var result = solution.FindAnagrams("cbaebabacd", "abc");
        Assert.That(result, Is.EqualTo(new List<int> { 0, 6 }));
    }

    [Test]
    public void ExampleCase2_ConsecutiveAnagrams()
    {
        var solution = new Solution438();
        var result = solution.FindAnagrams("abab", "ab");
        Assert.That(result, Is.EqualTo(new List<int> { 0, 1, 2 }));
    }

    [Test]
    public void NoAnagram_ReturnsEmpty()
    {
        var solution = new Solution438();
        var result = solution.FindAnagrams("abcdef", "xyz");
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void PatternLongerThanString_ReturnsEmpty()
    {
        var solution = new Solution438();
        var result = solution.FindAnagrams("ab", "abc");
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void ExactMatch_ReturnsSingleIndex()
    {
        var solution = new Solution438();
        var result = solution.FindAnagrams("abc", "abc");
        Assert.That(result, Is.EqualTo(new List<int> { 0 }));
    }

    [Test]
    public void DuplicateCharsInPattern()
    {
        var solution = new Solution438();
        var result = solution.FindAnagrams("aababc", "aab");
        Assert.That(result, Is.EqualTo(new List<int> { 0, 1 }));
    }
}
