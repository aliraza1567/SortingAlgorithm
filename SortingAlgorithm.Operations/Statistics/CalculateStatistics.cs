using System.Linq;
using System.Text.RegularExpressions;

namespace SortingAlgorithm.Operations.Statistics
{
    public class CalculateStatistics : ICalculateStatistics
    {
        public int GetSpecificCharCount(string text, char charToCount)
        {
            return text.Count(c => c == charToCount);
        }

        public int CountWords(string text)
        {
            var collection = Regex.Matches(text, @"[\S]+");
            return collection.Count;
        }
    }
}
