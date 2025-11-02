using System.Text;

namespace Algorithm;

// https://leetcode.cn/problems/zigzag-conversion/description/
public class Solution6
{
    public string Convert(string s, int numRows)
    {
        // handle one row case
        if (numRows == 1 || numRows > s.Length)
        {
            return s;
        }

        var rowStrBuilderList = new List<StringBuilder>();
        for (var i = 0; i < numRows; i++)
        {
            rowStrBuilderList.Add(new StringBuilder());
        }

        var curRow = 0;
        var flag = -1;
        foreach (var t in s)
        {
            if (curRow == 0 || curRow == numRows - 1)
            {
                flag = -flag;
            }

            rowStrBuilderList[curRow].Append(t);
            curRow += flag;
        }

        var resultStrBuilder = new StringBuilder();
        rowStrBuilderList.ForEach(item => resultStrBuilder.Append(item));
        return resultStrBuilder.ToString();
    }

    // 1. from line 0 to numRows-1, numRows chars；
    // 2. from line numRows-2 to 1, numRows-2 chars；
    // Cycle: T = numRows + numRows - 2 = 2 * (numRows - 1)
    //     
    // row No: r = i % T;
    // 1. if r < numRows, then line r;
    // 2. if r >= numRows, then line T - r;
    public string Convert2(string s, int numRows)
    {
        // handle one row case
        if (numRows == 1 || numRows > s.Length)
        {
            return s;
        }

        var rowStrBuilderList = new List<StringBuilder>();
        for (var i = 0; i < numRows; i++)
        {
            rowStrBuilderList.Add(new StringBuilder());
        }

        var curRow = 0;
        var t = 2 * numRows - 2;
        for (var i = 0; i < s.Length; i++)
        {
            var mod = i % t;
            if (mod < numRows)
            {
                curRow = mod;
            }
            else
            {
                curRow = t - mod;
            }

            rowStrBuilderList[curRow].Append(s[i]);
        }

        var resultStrBuilder = new StringBuilder();
        rowStrBuilderList.ForEach(item => resultStrBuilder.Append(item));
        return resultStrBuilder.ToString();
    }
}