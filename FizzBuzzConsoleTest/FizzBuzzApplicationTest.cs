using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzConsole;

namespace FizzBuzzApplicationTest
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_DivisibleBy3_ReturnsFizz()
        {
            // Arrange
            int number = 9;

            // Act
            string result = FizzBuzzApplication.FizzBuzz(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FizzBuzz_DivisibleBy5_ReturnsBuzz()
        {
            // Arrange
            int number = 20;

            // Act
            string result = FizzBuzzApplication.FizzBuzz(number);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzBuzz_DivisibleBy3And5_ReturnsFizzBuzz()
        {
            // Arrange
            int number = 30;

            // Act
            string result = FizzBuzzApplication.FizzBuzz(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void FizzBuzz_NotDivisibleBy3Or5_ReturnsNumberAsString()
        {
            // Arrange
            int number = 7;

            // Act
            string result = FizzBuzzApplication.FizzBuzz(number);

            // Assert
            Assert.AreEqual("7", result);
        }
    }
}
