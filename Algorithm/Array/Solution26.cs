namespace Algorithm.Array;

public class Solution26
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        var slow = 0;
        var fast = 0;

        while (fast < nums.Length)
        {
            if (nums[slow] != nums[fast])
            {
                slow++;
                nums[slow] = nums[fast];
            }
            fast++;
        }

        return slow + 1;
    }
}