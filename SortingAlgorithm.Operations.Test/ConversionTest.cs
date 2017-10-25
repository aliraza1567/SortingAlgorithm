using Microsoft.VisualStudio.TestTools.UnitTesting;
using OhpenTest.Operations.Convert;

namespace OhpenTest.Operations.Test
{
    [TestClass]
    public class ConversionTest
    {
        public static string TestString { get; } = "Mesut Ozil";
        public static string[] TestArray { get; } = { "Mesut", "Ozil" };

        [TestMethod]
        public void StringToArrayTest()
        {
            var actual = Conversion.StringToArray(TestString);

            CollectionAssert.AreEqual(TestArray, actual);
        }

        [TestMethod]
        public void ArrayToStringTest()
        {
            var actual = Conversion.ArrayToString(TestArray);

            Assert.AreEqual(TestString, actual);
        }
    }
}
