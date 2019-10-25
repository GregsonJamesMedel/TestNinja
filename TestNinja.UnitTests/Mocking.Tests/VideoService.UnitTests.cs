using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking.Tests
{
    [TestClass]
    public class VideoServiceUnitTests
    {
        [TestMethod]
        public void ReadVideoTitle_EmptyFIle_ReturnError()
        {
            var videoService = new VideoService(new FakeFileReader());

            var result = videoService.ReadVideoTitle();

            Assert.IsTrue(result.Contains("Error"));
        }
    }
}