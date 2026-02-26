namespace Algorithm.SlideWindow;

// https://leetcode.cn/problems/permutation-in-string/description/
public class Solution438
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var result = new List<int>();
        var left = 0;
        var right = 0;
        var valid = 0;
        var window = new Dictionary<char, int>();
        var need = new Dictionary<char, int>();

        foreach (var c in p)
        {
            if (!need.ContainsKey(c))
            {
                need[c] = 0;
            }
            need[c]++;
        }

        // 1. when to expand the window
        while (right < s.Length)
        {
            var curr = s[right];
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
            if (right - left >= p.Length)
            {
                // 3. when to update the result
                if (valid == need.Count)
                {
                    result.Add(left);
                }

                var leftChar = s[left];
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

        return result;
    }
}