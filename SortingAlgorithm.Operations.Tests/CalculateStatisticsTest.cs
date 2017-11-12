using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithm.Operations.Model;
using SortingAlgorithm.Operations.Statistics;

namespace SortingAlgorithm.Operations.Tests1
{
    [TestClass]
    public class CalculateStatisticsTest
    {
        public static string TestString { get; } = "I w-a-n-t t-o work at FIFA A-S-A-P";

        private readonly TextStatistics _expectedStatistics = new TextStatistics();
        private readonly int _expectedHyphensCount = 7;
        private readonly int _expectedWhiteSpaceCount = 6;
        private readonly int _expectedWordsCount = 7;

        private ICalculateStatistics _calculateStatistics;

        [TestMethod]
        public void StatisticsTest()
        {
            _expectedStatistics.Hyphens = _expectedHyphensCount;
            _expectedStatistics.WhiteSpace = _expectedWhiteSpaceCount;
            _expectedStatistics.Words = _expectedWordsCount;

            _calculateStatistics = new CalculateStatistics();

            var actual = new TextStatistics
            {
                Hyphens = _calculateStatistics.GetSpecificCharCount(TestString, '-'),
                Words = _calculateStatistics.CountWords(TestString),
                WhiteSpace = _calculateStatistics.GetSpecificCharCount(TestString, ' ')
            };

            Assert.AreEqual(_expectedStatistics.Hyphens, actual.Hyphens);
            Assert.AreEqual(_expectedStatistics.WhiteSpace, actual.WhiteSpace);
            Assert.AreEqual(_expectedStatistics.Words, actual.Words);
        }
    }
}
