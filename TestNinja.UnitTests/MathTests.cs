
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Math_AddTwoNumbers_ReturnTheSum()
        {
            var math = new Math();

            var result = math.Add(1,2);

            Assert.AreEqual(3,result);
        }

        [TestMethod]
        public void Max_FirstArgumentIsHigherThanTheSecond_ReturnsFirstArgument()
        {
            var math = new Math();

            var result = math.Max(2,1);

            Assert.AreEqual(2,result);
        }

        [TestMethod]
        public void Max_SecondArgumentIsHigherThanTheFirst_ReturnsSecondArgument()
        {
            var math = new Math();

            var result = math.Max(1,2);

            Assert.AreEqual(2,result);
        }

        [TestMethod]
        public void Max_BothArgumentsAreTheSame_ReturnsTheSame()
        {
            var math = new Math();

            var result = math.Max(1,1);

            Assert.AreEqual(1,result);
        }
    }
}