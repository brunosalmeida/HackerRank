using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HackerRankTest
{
    [TestClass]
    public class PlusMinusTest
    {
        [TestMethod]
        public void PlusMinusPrint()
        {
            var array = new int[] { -4, 3, -9, 0, 4, 1};

            var result = PlusMinus.PrintPlusMinus(array);

            Assert.AreEqual(0.500000, result[0]);
            Assert.AreEqual(0.333333, result[1]);
            Assert.AreEqual(0.166667, result[2]);
        }
    }
}
