using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseStringInArrayClassLibrary; 

namespace ReverseStringInArrayTest
{
    [TestClass]
    public class StringArrayReverserTest
    {
        [TestMethod]
        public void StringArrayIsEqual()
        {
            var exp = new string[] { "derf", "neb" };
            var arr = new string[] { "fred", "ben" };

            var result = StringArrayReverser.ReverseStringsInArray(arr);

            Assert.AreEqual(exp[0], result[0]);
            Assert.AreEqual(exp[1], result[1]);
        }

        [TestMethod]
        public void StringArrayIsNotEqual()
        {
            var exp = new string[] { "derf", "neb" };
            var arr = new string[] { "foo", "bar" };

            var result = StringArrayReverser.ReverseStringsInArray(arr);

            Assert.AreNotEqual(exp[0], result[0]);
            Assert.AreNotEqual(exp[1], result[1]);
        }

        [TestMethod]
        public void StringArrayIsEqualToLower()
        {
            var exp = new string[] { "derf", "neb" };
            var arr = new string[] { "Fred", "Ben" };

            var result = StringArrayReverser.ReverseStringsInArray(arr, true);

            Assert.AreEqual(exp[0], result[0]);
            Assert.AreEqual(exp[1], result[1]);
        }
    }
}
