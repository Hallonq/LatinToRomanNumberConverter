using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [DataRow(1)]
        public void check_if_null(int number)
        {
            Assert.IsNotNull(number, "rip");
        }

        [TestMethod]
        [DataRow(1)]
        public void check_if_positive(int number)
        {
            if (number < 0)
                Assert.Fail("rip");
        }

        [TestMethod]
        [DataRow(512)]
        public void if_returned_correct(int number)
        {
            // Arrange
            string expected = "DXII";
            LatinToRoman converter = new LatinToRoman();

            // Act
            string actual = converter.LatinToRomanConverter(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}