using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class HtmlFormatterTests
    {
        [TestMethod]
        public void FormatAsBold_WhenCalled_EnclosedArgumentWithStrongElement()
        {
            var htmlFormatter = new HtmlFormatter();

            var result = htmlFormatter.FormatAsBold("abc");

            Assert.AreEqual("<strong>abc</strong>",result);
        }
    }
}