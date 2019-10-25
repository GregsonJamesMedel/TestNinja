using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class CustonerControllerTests
    {
        [TestMethod]
        public void GetCustomer_CustomerIdIsZero_ReturnsNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            Assert.AreEqual(new NotFound().GetType(),result.GetType());
        }

        [TestMethod]
        public void GetCustomer_CustomerIdIsGreaterThanZero_ReturnsOk()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);

            Assert.AreEqual(new Ok().GetType(),result.GetType());
        }

    }
}