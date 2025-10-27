using Algorithm;

namespace AlgoTest;

public class Solution2Test
{
    [Test]
    public void Test1()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var solution = new Solution2();
        var result = solution.AddTwoNumbers(l1, l2);
        Assert.That(result.val, Is.EqualTo(7));
        Assert.That(result.next.val, Is.EqualTo(0));
        Assert.That(result.next.next.val, Is.EqualTo(8));
    }
    
    [Test]
    public void Test2()
    {
        var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        var solution = new Solution2();
        var result = solution.AddTwoNumbers(l1, l2);
        Assert.That(result.val, Is.EqualTo(8));
        Assert.That(result.next.val, Is.EqualTo(9));
        Assert.That(result.next.next.val, Is.EqualTo(9));
        Assert.That(result.next.next.next.val, Is.EqualTo(9));
        Assert.That(result.next.next.next.next.val, Is.EqualTo(0));
        Assert.That(result.next.next.next.next.next.val, Is.EqualTo(0));
        Assert.That(result.next.next.next.next.next.next.val, Is.EqualTo(0));
        Assert.That(result.next.next.next.next.next.next.next.val, Is.EqualTo(1));
    }
    
    [Test]
    public void Test3()
    {
        var l1 = new ListNode(0);
        var l2 = new ListNode(0);
        var solution = new Solution2();
        var result = solution.AddTwoNumbers(l1, l2);
        Assert.That(result.val, Is.EqualTo(0));
    }

    [Test]
    public void Test4()
    {
        var l1 = new ListNode(5);
        var l2 = new ListNode(5);
        var solution = new Solution2();
        var result = solution.AddTwoNumbers(l1, l2);
        Assert.That(result.val, Is.EqualTo(0));
        Assert.That(result.next.val, Is.EqualTo(1));
    }
}