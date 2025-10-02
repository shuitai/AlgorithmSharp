using Algorithm;

namespace AlgoTest;

public class Solution6Test
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var solution = new Solution6();
        var s = "PAYPALISHIRING";
        var numRows = 3;
        var result = solution.Convert(s, numRows);
        Assert.That(result, Is.EqualTo("PAHNAPLSIIGYIR"));
        
        s = "PAYPALISHIRING";
        numRows = 4;
        result = solution.Convert(s, numRows);
        Assert.That(result, Is.EqualTo("PINALSIGYAHRPI"));
    }

}