namespace TopInterviewQuestions;

/// <summary>
/// Longest Substring Without Repeating Characters
/// <see href="https://leetcode.com/problems/longest-substring-without-repeating-characters/"/>
/// </summary>
public class LongestSubstring
{
    public static int LengthOfLongestSubstring(string s)
    {
        var longest = 0;
        var subCount = 0;
        var substring = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            if (substring.ContainsKey(s[i]))
            {
                longest = Math.Max(longest, subCount);
                subCount = 0;
                i = substring[s[i]] + 1;
                substring.Clear();
            }

            substring.Add(s[i], i);
            subCount++;
        }

        return Math.Max(longest, subCount);
    }
}