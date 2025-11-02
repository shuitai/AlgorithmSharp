using Algorithm;

namespace AlgoTest;

public class Solution7Test
{
    [Test]
    public void Test1()
    {
        var solution = new Solution7();
        Assert.That(solution.Reverse(123), Is.EqualTo(321));
        Assert.That(solution.Reverse(-123), Is.EqualTo(-321));
        Assert.That(solution.Reverse(120), Is.EqualTo(21));
        Assert.That(solution.Reverse(0), Is.EqualTo(0));
        Assert.That(solution.Reverse(1534236469), Is.EqualTo(0));
    }
}