namespace Algorithm;

// https://leetcode.cn/problems/longest-palindromic-substring/description/
public class Solution5
{
    private int ExpandAround(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }

    // expand around center (O(n^2))
    public string LongestPalindrome(string s)
    {
        var left = 0;
        var right = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var len = ExpandAround(s, i, i);
            var len2 = ExpandAround(s, i, i + 1);
            len = Math.Max(len, len2);
            if (len > right - left)
            {
                left = i - (len - 1) / 2;
                right = i + len / 2;
            }
        }

        return s.Substring(left, right - left + 1);
    }
}