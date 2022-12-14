using FluentAssertions;
using Xunit;

namespace TopInterviewQuestions.UnitTest;

public class TwoSumTest
{
    [Theory]
    [InlineData(new[] {2, 7, 11, 15}, 9, new[] {0, 1})]
    [InlineData(new[] {3, 2, 4}, 6, new[] {1, 2})]
    [InlineData(new[] {3, 3}, 6, new[] {0, 1})]
    [InlineData(new[] {1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1}, 11, new[] {5, 11})]
    public void Given_integers_should_return_two_numbers_such_that_add_up_to_target(
        int[] nums, int target, int[] expected)
    {
        // Arrange & Act
        var result = TwoSum.Calculate(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}