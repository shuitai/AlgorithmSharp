namespace Algorithm;

// https://leetcode.cn/problems/reverse-integer/
public class Solution7
{
    public int Reverse(int x)
    {
        var result = 0;
        while (x != 0)
        {
            // check overflow
            if (result < int.MinValue / 10 || result > int.MaxValue / 10)
            {
                return 0;
            }

            // get digit
            var digit = x % 10;
            
            // update result
            result = result * 10 + digit;
            
            // remove last digit
            x /= 10;
        }

        return result;
    }
}