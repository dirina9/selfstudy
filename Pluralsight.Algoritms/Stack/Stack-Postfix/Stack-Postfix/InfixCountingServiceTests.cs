using NUnit.Framework;

namespace Stack_Postfix
{
    public class InfixCountingServiceTests
    {
        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void InfixCounting_WithInfix_ShouldReturnTrueResult()
        {
            // Arrange
            var expectedResult = 27;

            // Act
            int result = InfixCountingService.InfixCounting(new[] { "(", "5", "*", "3", ")", "+", "2", "*", "6"});

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void InfixCounting_WithSecondPriority_ShouldReturnTrueResult()
        {
            // Arrange
            var expectedResult = 1;

            // Act
            int result = InfixCountingService.InfixCounting(new[] { "5", "*", "2", "/", "10" });

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void InfixCounting_WithThirdPriority_ShouldReturnTrueResult()
        {
            // Arrange
            var expectedResult = 3;

            // Act
            int result = InfixCountingService.InfixCounting(new[] { "5", "-", "2" });

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void InfixCounting_WithInfixWithBrackets_ShouldReturnTrueResult()
        {
            // Arrange
            var expectedResult = 14;

            // Act
            int result = InfixCountingService.InfixCounting(new[] { "(", "5", "+", "2", ")", "*", "2" });

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}