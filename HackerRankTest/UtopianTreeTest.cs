using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTest
{
    [TestClass]
    public class UtopianTreeTest
    {
        [TestMethod]
        public void Calc0CycleTest()
        {
            var result = UtopianTree.CalcHeight(0);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Calc1CycleTest()
        {
            var result = UtopianTree.CalcHeight(1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Calc4CyclesTest()
        {
            var result = UtopianTree.CalcHeight(4);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Calc5CyclesTest()
        {
            var result = UtopianTree.CalcHeight(5);

            Assert.AreEqual(14, result);
        }
    }
}