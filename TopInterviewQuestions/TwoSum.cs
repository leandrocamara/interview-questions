namespace TopInterviewQuestions;

/// <summary>
/// Two Sum
/// <see href="https://leetcode.com/problems/two-sum/"/>
/// </summary>
public class TwoSum
{
    public static int[] Calculate(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var currentKey = target - nums[i];
            if (map.ContainsKey(currentKey))
                return new[] {map[currentKey], i};

            if (map.ContainsKey(nums[i]) == false)
                map.Add(nums[i], i);
        }
        return new int[2];
    }
}