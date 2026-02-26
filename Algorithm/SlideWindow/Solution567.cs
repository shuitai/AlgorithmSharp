namespace Algorithm.SlideWindow;

// https://leetcode.cn/problems/permutation-in-string/description/
public class Solution567
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
        {
            return false;
        }

        var left = 0;
        var right = 0;
        var valid = 0;
        var window = new Dictionary<char, int>();
        var need = new Dictionary<char, int>();

        foreach (var c in s1)
        {
            if (!need.ContainsKey(c))
            {
                need[c] = 0;
            }
            need[c]++;
        }

        // 1. when to expand the window
        while (right < s2.Length)
        {
            var curr = s2[right];
            right++;
            
            if (need.ContainsKey(curr))
            {
                window[curr] = window.GetValueOrDefault(curr, 0) + 1;
                if (need[curr] == window[curr])
                {
                    valid++;
                }
            }

            // 2. when to shrink the window
            if (right - left >= s1.Length)
            {
                // 3. when to update the result
                if (valid == need.Count)
                {
                    return true;
                }
                
                var leftChar = s2[left];
                left++;
                
                if (need.ContainsKey(leftChar))
                {
                    if (need[leftChar] == window[leftChar])
                    {
                        valid--;
                    }
                    window[leftChar] = window.GetValueOrDefault(leftChar, 0) - 1;
                }
            }
        }

        return false;
    }
}