namespace Algorithm;

// https://leetcode.cn/problems/longest-substring-without-repeating-characters/
public class Solution3
{
    // slide window
    public int LengthOfLongestSubstring(string s)
    {
        var length = s.Length;
        var left = 0;
        var right = 0;
        
        var cache = new Dictionary<char, int>();
        var result = 0;

        while (right < length)
        {
            var currChat = s[right];
            if (cache.TryGetValue(currChat, out var lengthOfLeft))
            {
                left = Math.Max(left, lengthOfLeft + 1);
            }
            cache[currChat] = right;
            right++;
            
            result = Math.Max(result, right - left);
        }
        return result;
    }
}