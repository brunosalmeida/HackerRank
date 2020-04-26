using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HackerRankTest
{
    [TestClass]
    public class MiniMaxSumTest
    {
        [TestMethod]
        public void SumTest()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };

            var result = MiniMaxSum.Sum(array);

            Assert.AreEqual("10 14", result);
        }
    }
}
