namespace Algorithm.SlideWindow;

// when to expand the window
// when to shrink the window
// when to update the result

// slide window
// https://leetcode.cn/problems/longest-substring-without-repeating-characters/
public class Solution3
{
    public int LengthOfLongestSubstring(string s)
    {
        var left = 0;
        var right = 0;
        var window = new Dictionary<char, int>();

        var res = 0;
        // when to expand the window
        while (right < s.Length)
        {
            var curr = s[right];
            right++;
            window[curr] = window.GetValueOrDefault(curr, 0) + 1;

            // when to shrink the window
            while (window[curr] > 1)
            {
                var leftChar = s[left];
                left++;
                
                window[leftChar] = window.GetValueOrDefault(leftChar, 0) - 1;
            }
            
            // when to update the result
            res = Math.Max(res, right - left);
        }

        return res;
    }
    
    public int LengthOfLongestSubstring2(string s)
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