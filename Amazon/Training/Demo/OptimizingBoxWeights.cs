namespace Amazon.Training.Demo;

public class OptimizingBoxWeights
{
    private IEnumerable<int> Set { get; }

    public OptimizingBoxWeights(IEnumerable<int> set)
    {
        Set = set.OrderByDescending(i => i);
    }

    public IEnumerable<int> MinimalHeaviest()
    {
        var setSum = Set.Sum();
        var minimalHeaviestSum = 0;
        var minimalHeaviestSet = new Stack<int>();

        foreach (var item in Set)
        {
            setSum -= item;
            minimalHeaviestSum += item;
            minimalHeaviestSet.Push(item);

            if (minimalHeaviestSum > setSum) break;
        }

        return minimalHeaviestSet;
    }
}