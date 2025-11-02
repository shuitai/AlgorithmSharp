using Algorithm;

namespace AlgoTest;

public class Solution9Test
{
    [Test]
    public void Test1()
    {
        var solution = new Solution9();
        var result = solution.IsPalindrome(121);
        Assert.That(result, Is.EqualTo(true));
        
        result = solution.IsPalindrome(-121);
        Assert.That(result, Is.EqualTo(false));
        
        result = solution.IsPalindrome(10);
        Assert.That(result, Is.EqualTo(false));
    }
}