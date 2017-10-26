using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithm.Operations.Conversion;
using SortingAlgorithm.Operations.Sortings;

namespace SortingAlgorithm.Operations.Tests
{
    [TestClass]
    public class SortingTest
    {
        public static string TestString { get; } = "I w-a-n-t t-o work at some company A-S-A-P";
        public static string ExpectedResult { get; } = "A-S-A-P at company I some t-o w-a-n-t work";
        private ISorting _sorting;

        [TestMethod]
        public void SelectionSortTest()
        {
            _sorting = new Sorting();

            var actual = Convert.ArrayToString(_sorting.SelectionSort(Convert.StringToArray(TestString)));

            Assert.AreEqual(ExpectedResult, actual);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            _sorting = new Sorting();

            var actual = Convert.ArrayToString(_sorting.InsertionSort(Convert.StringToArray(TestString)));

            Assert.AreEqual(ExpectedResult, actual);
        }

        [TestMethod]
        public void BubbleSortTest()
        {
            _sorting = new Sorting();

            var actual = Convert.ArrayToString(_sorting.BubbleSort(Convert.StringToArray(TestString)));

            Assert.AreEqual(ExpectedResult, actual);
        }
    }
}
