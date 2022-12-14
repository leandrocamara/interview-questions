using FluentAssertions;
using Xunit;

namespace TopInterviewQuestions.UnitTest;

public class AddTwoNumbersTest
{
    [Theory]
    [ClassData(typeof(AddTwoNumbersSeed))]
    public void Given_linked_lists_should_return_reverse_order_sum_linked_list(AddTwoNumbersSeedData seed)
    {
        // Arrange & Act
        var result = AddTwoNumbers.ReverseOrderSum(seed.FirstList, seed.SecondList);

        // Assert
        result.Should().BeEquivalentTo(seed.ExpectedReverseOrderSumList);
    }
}

public class AddTwoNumbersSeed : TheoryData<AddTwoNumbersSeedData>
{
    public AddTwoNumbersSeed()
    {
        Add(new AddTwoNumbersSeedData(new[] {2, 4, 3}, new[] {5, 6, 4}, new[] {7, 0, 8}));
        Add(new AddTwoNumbersSeedData(new[] {0}, new[] {0}, new[] {0}));
        Add(new AddTwoNumbersSeedData(new[] {9, 9, 9, 9, 9, 9, 9}, new[] {9, 9, 9, 9}, new[] {8, 9, 9, 9, 0, 0, 0, 1}));
    }
}

public class AddTwoNumbersSeedData
{
    public ListNode FirstList { get; }
    public ListNode SecondList { get; }
    public ListNode ExpectedReverseOrderSumList { get; }

    public AddTwoNumbersSeedData(int[] firstList, int[] secondList, int[] expectedReverseOrderSumList)
    {
        FirstList = ConvertFrom(firstList);
        SecondList = ConvertFrom(secondList);
        ExpectedReverseOrderSumList = ConvertFrom(expectedReverseOrderSumList);
    }

    private ListNode ConvertFrom(int[] list)
    {
        var current = new ListNode(list[0]);
        var root = current;

        for (var i = 1; i < list.Length; i++)
        {
            current.next = new ListNode(list[i]);
            current = current.next;
        }

        return root;
    }
}