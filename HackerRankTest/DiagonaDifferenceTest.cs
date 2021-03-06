﻿using HackerRank;
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

            var array0 = new List<int>() { 11, 2, 4 };
            var array1 = new List<int>() { 4, 5, 6 };
            var array2 = new List<int>() { 10, 8, -12 };

            arrays.Add(array0);
            arrays.Add(array1);
            arrays.Add(array2);

            var result = DiagonalDifference.SumRightToLeftDiagonal(arrays);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SumLeftToRightTest()
        {
            var arrays = new List<List<int>>();

            var array0 = new List<int>() { 11, 2, 4 };
            var array1 = new List<int>() { 4, 5, 6 };
            var array2 = new List<int>() { 10, 8, -12 };

            arrays.Add(array0);
            arrays.Add(array1);
            arrays.Add(array2);

            var result = DiagonalDifference.SumLeftToRightDiagonal(arrays);

            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void DifferenceTest()
        {
            var arrays = new List<List<int>>();

            var array0 = new List<int>() { 11, 2, 4 };
            var array1 = new List<int>() { 4, 5, 6 };
            var array2 = new List<int>() { 10, 8, -12 };

            arrays.Add(array0);
            arrays.Add(array1);
            arrays.Add(array2);

            var result = DiagonalDifference.Difference(arrays);

            Assert.AreEqual((11 + 5 - 12) - (4 + 5 + 10), result);
        }
    }
}
