using NUnit.Framework;

namespace Stack_FromInfixToPostfix
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Calculate_WithString_ShouldReturnTrueResult()
        {
            // Arrange
            string str = "5 + 2 * 3";
            int expectedResult = 11;

            // Act
            int result = Calculator.Calculate(str);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Calculate_WithStringWithIncorrectCharacters_ShouldReturnTrueResult()
        {
            // Arrange
            //5 8 2 - 3 / +
            //5 + 8 2 - 3 /
            string str = "5+ (8- 2)  ty /3";
            int expectedResult = 7;

            // Act
            int result = Calculator.Calculate(str);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}