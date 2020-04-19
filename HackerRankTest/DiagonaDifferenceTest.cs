using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRankTest
{
    [TestClass]
    public class DiagonaDifferenceTest
    {
        [TestMethod]
        public void SumRightToLeftTest()
        {
            var arrays = new List<List<int>>();

            var array0 = new List<int>() { 1, 3, 5 };
            var array1 = new List<int>() { 7, 9, 11 };
            var array2 = new List<int>() { 12, 15, 17 };

            arrays.Add(array0);
            arrays.Add(array1);
            arrays.Add(array2);

            var result = DiagonalDifference.SumRightToLeftDiagonal(arrays);

            Assert.AreEqual((1 + 9 + 17), result);
        }

        [TestMethod]
        public void SumLeftToRightTest()
        {
            var arrays = new List<List<int>>();

            var array0 = new List<int>() { 1, 3, 5 };
            var array1 = new List<int>() { 7, 9, 11 };
            var array2 = new List<int>() { 12, 15, 17 };

            arrays.Add(array0);
            arrays.Add(array1);
            arrays.Add(array2);

            var result = DiagonalDifference.SumLeftToRightDiagonal(arrays);

            Assert.AreEqual((5 + 9 + 12), result);
        }

        [TestMethod]
        public void DifferenceTest()
        {
            var arrays = new List<List<int>>();

            var array0 = new List<int>() { 1, 3, 5 };
            var array1 = new List<int>() { 7, 9, 11 };
            var array2 = new List<int>() { 12, 15, 17 };

            arrays.Add(array0);
            arrays.Add(array1);
            arrays.Add(array2);

            var result = DiagonalDifference.Difference(arrays);

            Assert.AreEqual((1 + 9 + 17) - (5 + 9 + 12), result);
        }
    }
}
