using Microsoft.VisualStudio.TestTools.UnitTesting;
using OhpenTest.Operations.Convert;
using OhpenTest.Operations.Sorting;

namespace OhpenTest.Operations.Test
{
    [TestClass]
    public class SortingTest
    {
        public static string TestString { get; } = "I w-a-n-t t-o work at some company A-S-A-P";
        public static string ExpectedResult { get; } = "A-S-A-P at I some company t-o w-a-n-t work";
        private ISorting _sorting;

        [TestMethod]
        public void SelectionSortTest()
        {
            _sorting = new Sorting.Sorting();

            var actual = Conversion.ArrayToString(_sorting.SelectionSort(Conversion.StringToArray(TestString)));

            Assert.AreEqual(ExpectedResult, actual);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            _sorting = new Sorting.Sorting();

            var actual = Conversion.ArrayToString(_sorting.InsertionSort(Conversion.StringToArray(TestString)));

            Assert.AreEqual(ExpectedResult, actual);
        }

        [TestMethod]
        public void BubbleSortTest()
        {
            _sorting = new Sorting.Sorting();

            var actual = Conversion.ArrayToString(_sorting.BubbleSort(Conversion.StringToArray(TestString)));

            Assert.AreEqual(ExpectedResult, actual);
        }
    }
}
