using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRankTest
{
    [TestClass]
    public class GradingStudentsTest
    {
        [TestMethod]
        public void RoundGradeTest()
        {
            var array = new List<int> { 73, 67, 38, 33 };
            var result = GradingStudents.Round(array);

            Assert.IsTrue(result.Count == array.Count);
            Assert.AreEqual(75, result[0]);
            Assert.AreEqual(67, result[1]);
            Assert.AreEqual(40, result[2]);
            Assert.AreEqual(33, result[3]);
        }

        [TestMethod]
        public void Round37And38GradeTest()
        {
            var array = new List<int> { 37, 38 };
            var result = GradingStudents.Round(array);

            Assert.IsTrue(result.Count == array.Count);
            Assert.AreEqual(37, result[0]);
            Assert.AreEqual(40, result[1]);
        }

        [TestMethod]
        public void Round100GradeTest()
        {
            var array = new List<int> { 100 };
            var result = GradingStudents.Round(array);

            Assert.IsTrue(result.Count == array.Count);
            Assert.AreEqual(100, result[0]);
        }
    }
}