using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HackerRankTest
{
    [TestClass]
    public class SimpleArraySumTest
    {
        [TestMethod]
        public void ArraySumTest()
        {
            var array = new int[] { 1, 2, 3, 4, 10, 11 };

            var result = SimpleArraySum.ArraySum(array);

            Assert.AreEqual(array.Sum(), result);
        }
    }
}
