using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking.Tests
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}