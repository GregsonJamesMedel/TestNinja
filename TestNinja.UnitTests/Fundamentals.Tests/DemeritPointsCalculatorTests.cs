using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class DemeritPointsCalculatorTests
    {
        [TestMethod]
        public void CalculateDemeritPoints_SpeedIsLessThanZero_ThrowsArgumentOutOfRangeException()
        {
            var dpCalculator = new DemeritPointsCalculator();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dpCalculator.CalculateDemeritPoints(-1));
        }

        [TestMethod]
        public void CalculateDemeritPoints_SpeedIsGreaterThanMaximumSpeedLimit_ThrowsArgumentOutOfRangeException()
        {
            var dpCalculator = new DemeritPointsCalculator();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dpCalculator.CalculateDemeritPoints(301));
        }

        [TestMethod]
        public void CalculateDemeritPoints_SpeedIsLessThanOrEqualToSpeedLimit_ReturnZero()
        {
            var dpCalculator = new DemeritPointsCalculator();

            var result = dpCalculator.CalculateDemeritPoints(1);

            Assert.AreEqual(0,result);
        }

        [TestMethod]
        public void CalculateDemeritPoints_SpeedIsGreaterThanSpeedLimitAndLessThanMaximumSpeed_ReturnCalculatedDemeritPoints()
        {
            var dpCalculator = new DemeritPointsCalculator();

            var result = dpCalculator.CalculateDemeritPoints(70);

            Assert.AreEqual(1,result);
        }
    }
}