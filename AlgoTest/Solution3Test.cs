using Algorithm;

namespace AlgoTest;

public class Solution3Test
{
    [Test]
    public void Test1()
    {
        var solution = new Solution3();
        var result = solution.LengthOfLongestSubstring("abcabcbb");
        Assert.That(result, Is.EqualTo(3));
        
        result = solution.LengthOfLongestSubstring("bbbbb");
        Assert.That(result, Is.EqualTo(1));
        
        result = solution.LengthOfLongestSubstring("pwwkew");
        Assert.That(result, Is.EqualTo(3));
    }
}