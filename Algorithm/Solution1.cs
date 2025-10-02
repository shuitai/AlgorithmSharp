namespace Algorithm;
// solution1
public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        var cache = new Dictionary<int, int>(16);

        for (var i = 0; i < nums.Length; i++)
        {
            if (cache.TryGetValue(target - nums[i], out var index))
            {
                return [index, i];
            }
            
            cache.TryAdd(nums[i], i);
        }

        throw new ArgumentException();
    }
}