using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithm.Operations.Conversion;

namespace SortingAlgorithm.Operations.Tests
{
    [TestClass]
    public class ConversionTest
    {
        public static string TestString { get; } = "Mesut Ozil";
        public static string[] TestArray { get; } = { "Mesut", "Ozil" };

        [TestMethod]
        public void StringToArrayTest()
        {
            var actual = Convert.StringToArray(TestString);

            CollectionAssert.AreEqual(TestArray, actual);
        }

        [TestMethod]
        public void ArrayToStringTest()
        {
            var actual = Convert.ArrayToString(TestArray);

            Assert.AreEqual(TestString, actual);
        }
    }
}
