using NUnit.Framework;

namespace Stack_FromInfixToPostfix
{
    [TestFixture]
    public class PostfixServiceTests
    {
        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void PostfixCount_WithInfix_ShouldReturnTrueResult()
        {
            // Arrange
            var expectedResult = 27;

            // args = "5 + 2 * 3"
            // res = 11

            // args = "5+ (8- 2)  ty /3"
            // res = 7

            // Act
            int result = PostfixService.PostfixCount(new[] { "5", "3", "*", "2", "6", "*", "+" });

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void PostfixCount_WithSecondPriority_ShouldReturnTrueResult()
        {
            // Arrange
            var expectedResult = 1;

            // Act
            int result = PostfixService.PostfixCount(new[] { "5", "2", "*", "10", "/" });

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void PostfixCount_WithThirdPriority_ShouldReturnTrueResult()
        {
            // Arrange
            var expectedResult = 3;

            // Act
            int result = PostfixService.PostfixCount(new[] { "5", "2", "-" });

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void PostfixCount_WithInfixWithBrackets_ShouldReturnTrueResult()
        {
            // Arrange
            var expectedResult = 14;

            // Act
            int result = PostfixService.PostfixCount(new[] { "5", "2", "+", "2", "*" });

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}