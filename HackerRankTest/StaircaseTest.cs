using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTest
{
    [TestClass]
    public class StaircaseTest
    {
        [TestMethod]
        public void StaircasePrint()
        {
            var result = Staircase.Stair(6);

            Assert.AreEqual("     #", result[0]);
            Assert.AreEqual("    ##", result[1]);
            Assert.AreEqual("   ###", result[2]);
            Assert.AreEqual("  ####", result[3]);
            Assert.AreEqual(" #####", result[4]);
            Assert.AreEqual("######", result[5]);
        }
    }
}
