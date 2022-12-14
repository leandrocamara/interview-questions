using FluentAssertions;
using Xunit;

namespace TopInterviewQuestions.UnitTest;

public class LongestSubstringTest
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("dvdf", 3)]
    public void Given_string_should_return_longest_substring_without_repeating_characters(string input, int expected)
    {
        // Arrange & Act
        var result = LongestSubstring.LengthOfLongestSubstring(input);

        // Assert
        result.Should().Be(expected);
    }
}