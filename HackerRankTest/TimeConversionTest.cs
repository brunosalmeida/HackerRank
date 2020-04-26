using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HackerRankTest
{
    [TestClass]
    public class TimeConversionTest
    {
        [TestMethod]
        public void ConvertPMTest()
        {
            var date = "07:05:45PM";
            var result = TimeConversion.Convert(date);

            Assert.AreEqual("19:05:45", result);
        }

        [TestMethod]
        public void ConvertAMTest()
        {
            var date = "07:05:45AM";
            var result = TimeConversion.Convert(date);

            Assert.AreEqual("07:05:45", result);
        }

        [TestMethod]
        public void Convert00AMTest()
        {
            var date = "00:00:00AM";
            var result = TimeConversion.Convert(date);

            Assert.AreEqual("00:00:00", result);
        }

    }
}
