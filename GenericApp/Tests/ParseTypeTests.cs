using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericApp.Common.Tests
{
    [TestClass()]
    public class ParseTypeTests
    {
        [TestMethod()]
        public void ParseType_Success()
        {
            // Arrange
            var TestRegex = new GenericApp.Common.RegexSamples();
            var fileName = "1234A.TXT";
            var expected = "A";

            TestRegex.FileName = fileName;

            // Act
            var actual = TestRegex.ParseType();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
