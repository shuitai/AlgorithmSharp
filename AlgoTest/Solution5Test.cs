using Algorithm;

namespace AlgoTest;

public class Solution5Test
{
    [Test]
    public void Test1()
    {
        var s = "babad";
        var solution = new Solution5();
        var result = solution.LongestPalindrome(s);
        Assert.That(result, Is.EqualTo("aba"));
        
        s = "cbbd";
        result = solution.LongestPalindrome(s);
        Assert.That(result, Is.EqualTo("bb"));
    }
}