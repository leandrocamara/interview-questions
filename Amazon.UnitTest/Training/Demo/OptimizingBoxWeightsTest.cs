using Amazon.Training.Demo;
using FluentAssertions;
using Xunit;

namespace Amazon.UnitTest.Training.Demo;

public class OptimizingBoxWeightsTest
{
    [Theory]
    [InlineData(new[] {5, 3, 2, 4, 1, 2}, new[] {4, 5})]
    [InlineData(new[] {4, 2, 5, 1, 6}, new[] {5, 6})]
    public void Given_set_should_return_minimal_heaviest_set(int[] set, int[] expected)
    {
        // Arrange
        var optimizingBoxWeights = new OptimizingBoxWeights(set);

        // Act
        var minimalHeaviest = optimizingBoxWeights.MinimalHeaviest();

        // Assert
        minimalHeaviest.Should().BeEquivalentTo(expected);
    }
}