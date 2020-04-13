using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRankTest
{
    [TestClass]
    public class CompareTripletsTest
    {
        [TestMethod]
        public void CompareTest()
        {
            var listA = new List<int> { 10, 20, 30 };
            var listB = new List<int> { 30, 20, 10 };

            var listResult = CompareTriplets.Compare(listA, listB);

            Assert.IsTrue(listResult.Count == 2);
            Assert.IsTrue(listResult[0] == 1);
            Assert.IsTrue(listResult[1] == 1);
        }
    }
}
