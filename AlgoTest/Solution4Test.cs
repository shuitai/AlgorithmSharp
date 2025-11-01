using Algorithm;

namespace AlgoTest;

public class Solution4Test
{
    [Test]
    public void Test()
    {
        var solution = new Solution4();
        var nums1 = new[] { 1, 3 };
        var nums2 = new[] { 2 };
        var result = solution.FindMedianSortedArrays(nums1, nums2);
        Assert.That(result, Is.EqualTo(2.0));
        
        nums1 = new[] { 1, 2 };
        nums2 = new[] { 3, 4 };
        result = solution.FindMedianSortedArrays(nums1, nums2);
        Assert.That(result, Is.EqualTo(2.5));
    }
}