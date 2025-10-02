using System.Text;

namespace Algorithm;

public class Solution6
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }
        
        var minLen = Math.Min(s.Length, numRows);
        var rowStrBuilderList = new List<StringBuilder>();
        for (var i = 0; i < minLen; i++)
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
}