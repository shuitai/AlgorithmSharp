namespace Algorithm.SlideWindow;

// https://leetcode.cn/problems/minimum-window-substring/description/
public class Solution76
{
    public string MinWindow(string s, string t) {
        var window = new Dictionary<char, int>();
        var need = new Dictionary<char, int>();
        
        foreach (var c in t)
        {
            if (!need.ContainsKey(c))
            {
                need[c] = 0;
            }
            need[c]++;
        }
        
        int left = 0, right = 0;
        var valid = 0;
        int start = 0;
        int len = Int32.MaxValue;
        
        // expand the window
        while (right < s.Length)
        {
            var c = s[right];
            right++;

            if (need.ContainsKey(c))
            {
                window[c] = window.GetValueOrDefault(c, 0) + 1;
                if (window[c] == need[c])
                {
                    valid++;
                }
            }

            // when to shrink the window
            while (valid == need.Count)
            {
                // record the result startPos and length
                if (right - left < len) {
                    start = left;
                    len = right - left;
                }
                
                var leftChar = s[left];
                left++;
                if (need.ContainsKey(leftChar))
                {
                    if (window[leftChar] == need[leftChar])
                    {
                        valid--;
                    }
                    window[leftChar] = window.GetValueOrDefault(leftChar, 0) - 1;
                }
            }
        }

        return len != Int32.MaxValue ? s.Substring(start, len) : "";
    }
}