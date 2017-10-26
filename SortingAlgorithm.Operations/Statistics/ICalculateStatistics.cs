namespace SortingAlgorithm.Operations.Statistics
{
    public interface ICalculateStatistics
    {
        int GetSpecificCharCount(string text, char charToCount);

        int CountWords(string text);
    }
}
