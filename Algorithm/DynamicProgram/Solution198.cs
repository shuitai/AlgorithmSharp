namespace Algorithm.DynamicProgram;

public class Solution198
{
    // DP template
    // 1. define state: dp[i] as the max value of robbing from 0 to i
    // 2. corner case: dp[0] = nums[0] dp[1] = max(nums[0], nums[1]) dp[2] = max(dp[1], dp[0] + nums[2])
    // 3. transfer function: dp[i] = max(dp[i - 1], dp[i - 2] + nums[i])
    // 4. from bottom to top or from top to bottom
    // 5. return value: dp[nums.Length - 1]
    public int Rob(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var dp = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            switch (i)
            {
                case 0:
                    dp[0] = nums[0];
                    break;
                case 1:
                    dp[1] = Math.Max(nums[0], nums[1]);
                    break;
                default:
                    dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
                    break;
            }
        }
        
        return dp[nums.Length - 1];
    }
}