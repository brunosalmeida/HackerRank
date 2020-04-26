using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRankTest
{
    [TestClass]
    public class BirthdayCakeCandlesTest
    {
        [TestMethod]
        public void Calc()
        {
            var array = new int[] { 3, 2, 1, 3 };
            var result = BirthdayCakeCandles.Calc(array);

            Assert.AreEqual(2, result);
        }
    }
}
