namespace Algorithm;

//https://leetcode.cn/problems/median-of-two-sorted-arrays/
public class Solution4
{
    // merge two sorted array
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var totalLength = nums1.Length + nums2.Length;
        var result = new int[totalLength];
        
        // merge two array
        var i = 0;
        var j = 0;
        var c = 0;
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                result[c++] = nums1[i++];
            }
            else
            {
                result[c++] = nums2[j++];
            }
        }

        if (i < nums1.Length)
        {
            Array.Copy(nums1, i, result, c, nums1.Length - i);
        }

        if (j < nums2.Length)
        {
            Array.Copy(nums2, j, result, c, nums2.Length - j);
        }
        
        if (totalLength % 2 == 0)
        {
            return (result[totalLength / 2 - 1] + result[totalLength / 2]) / 2.0;
        }
        return result[totalLength / 2];
    }
}