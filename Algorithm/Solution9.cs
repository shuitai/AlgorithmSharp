using System.Text;

namespace Algorithm;

// https://leetcode.cn/problems/palindrome-number/
public class Solution9
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        
        var result = new StringBuilder();
        while(x != 0)
        {
            var digit = x % 10;
            result.Append(Math.Abs(digit));
            x /= 10;
        }

        var left = 0;
        var right = result.Length - 1;
        while(left < right)
        {
            if (result[left] != result[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}