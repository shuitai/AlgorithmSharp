namespace Algorithm.DynamicProgram;

public class Solution213
{
    // DP template
    // 1. define state: dp[i] as the max value of robbing from 0 to i
    // 2. corner case: dp[0] = nums[0] dp[1] = max(nums[0], nums[1]) dp[2] = max(dp[1], dp[0] + nums[2])
    // 3. transfer function: dp[i] = max(dp[i - 1], dp[i - 2] + nums[i])
    // 4. from bottom to top or from top to bottom
    // 5. return value: dp[end - 1]
    private int RobRange(int[] nums, int start, int end)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var dp = new int[end + 1];
        for (var i = start; i <= end; i++)
        {
            if (i == start)
            {
                dp[i] = nums[i];
            }
            else if (i == start + 1)
            {
                dp[i] = Math.Max(nums[start], nums[start + 1]);
            }
            else
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }
        }

        return dp[end];
    }

    public int Rob(int[] nums)
    {
        int n = nums.Length;
        if (n == 0) return 0;
        if (n == 1) return nums[0];
        if (n == 2) return Math.Max(nums[0], nums[1]);
        return Math.Max(RobRange(nums, 0, n - 2), RobRange(nums, 1, n - 1));
    }
}