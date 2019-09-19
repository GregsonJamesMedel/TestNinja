using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class FizzBuzzUnitTests
    {
        [TestMethod]
        public void GetOutput_ParamIsDivisibleBy3_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.AreEqual("Fizz",result);
        }

        [TestMethod]
        public void GetOutput_ParamIsDivisibleBy5_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(10);

            Assert.AreEqual("Buzz",result);
        }

        [TestMethod]
        public void GetOutput_ParamIsDivisibleBy3And5_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.AreEqual("FizzBuzz",result);
        }

        [TestMethod]
        public void GetOutput_ParamIsNotDivisibleBy3And5_ReturnsNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.AreEqual("1",result);
        }
    }
}