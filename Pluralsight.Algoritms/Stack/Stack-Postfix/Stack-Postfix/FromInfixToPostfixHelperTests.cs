using System.Collections.Generic;
using NUnit.Framework;

namespace Stack_Postfix
{
    [TestFixture]
    public class FromInfixToPostfixHelperTests
    {
        public Stack<Operand> InitStackWithOneOpenedBracketBeforeTest()
        {
            Stack<Operand> operandsStack = new Stack<Operand>();
            operandsStack.Push(new Operand("-"));
            operandsStack.Push(new Operand("("));
            operandsStack.Push(new Operand("*"));
            operandsStack.Push(new Operand("+"));
            return operandsStack;
        }

        public Stack<Operand> InitStackWithoutBracketsBeforeTest()
        {
            Stack<Operand> operandsStack = new Stack<Operand>();
            operandsStack.Push(new Operand("-"));
            operandsStack.Push(new Operand("*"));
            operandsStack.Push(new Operand("/"));
            return operandsStack;
        }

        public List<string> InitOriginalPostfix()
        {
            List<string> postfix = new List<string>();
            postfix.Add("5");
            postfix.Add("2");
            return postfix;
        }

        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void HandleBracket_WithCorrectedPostfix_ShouldReturnPostfixWithoutOpenedBracketAndWithoutLastStackElement()
        {
            // Arrange
            Stack<Operand> operandsStack = InitStackWithOneOpenedBracketBeforeTest();
            List<string> postfix = InitOriginalPostfix();
            List<string> expectedPostfix = new List<string>();
            expectedPostfix.Add("5");
            expectedPostfix.Add("2");
            expectedPostfix.Add("+");
            expectedPostfix.Add("*");
          
            // Act
            FromInfixToPostfixHelper.HandleBracket(operandsStack, postfix);

            // Assert
            CollectionAssert.AreEqual(postfix, expectedPostfix);
        }

        [Test]
        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
        public void HandleBracket_WithIncorrectedPostfix_ShouldReturnPostfixWithoutOpenedBracketAndWithoutLastStackElement()
        {
            // Arrange
            Stack<Operand> operandsStack = InitStackWithOneOpenedBracketBeforeTest();
            List<string> postfix = InitOriginalPostfix();
            List<string> expectedPostfix = new List<string>();
            expectedPostfix.Add("5");
            expectedPostfix.Add("2");
            expectedPostfix.Add("-");
            expectedPostfix.Add("*");
            
            // Act
            FromInfixToPostfixHelper.HandleBracket(operandsStack, postfix);

            // Assert
            CollectionAssert.AreNotEqual(postfix, expectedPostfix);
        }

        [Test]
        //пока приоритет oператора меньше либо равен приоритету оператора, находящегося на вершине стека выталкиваем верхний элемент стека в выходную строку
        public void ReplaceElementsFromStackToString_WithOperandPriorityEqualFirstElementInStack_ShouldReturnPostfixWithMorePriorityOperands()
        {
            // Arrange
            Stack<Operand> operandsStack = InitStackWithoutBracketsBeforeTest();
            List<string> postfix = InitOriginalPostfix();
            List<string> expectedPostfix = new List<string>();
            expectedPostfix.Add("5");
            expectedPostfix.Add("2");
            expectedPostfix.Add("/");
            expectedPostfix.Add("*");
            
            // Act
            FromInfixToPostfixHelper.ReplaceElementsFromStackToString(new Operand("*"), operandsStack, postfix);

            // Assert
            CollectionAssert.AreEqual(postfix, expectedPostfix);
        }

        [Test]
        //пока приоритет oператора меньше либо равен приоритету оператора, находящегося на вершине стека выталкиваем верхний элемент стека в выходную строку
        public void ReplaceElementsFromStackToString_WithOperandPriorityLessThanFirstElementInStack_ShouldReturnPostfixWithMorePriorityOperands()
        {
            // Arrange
            Stack<Operand> operandsStack = InitStackWithoutBracketsBeforeTest();
            List<string> postfix = InitOriginalPostfix();
            List<string> expectedPostfix = new List<string>();
            expectedPostfix.Add("5");
            expectedPostfix.Add("2");
            expectedPostfix.Add("/");
            expectedPostfix.Add("*");
            expectedPostfix.Add("-");
            
            // Act
            FromInfixToPostfixHelper.ReplaceElementsFromStackToString(new Operand("+"), operandsStack, postfix);

            // Assert
            CollectionAssert.AreEqual(postfix, expectedPostfix);
        }

        [Test]
        //пока приоритет oператора меньше либо равен приоритету оператора, находящегося на вершине стека выталкиваем верхний элемент стека в выходную строку
        public void ReplaceElementsFromStackToString_WithOpenedBracketOperand_ShouldReturnPostfixWithMorePriorityOperands()
        {
            // Arrange
            Stack<Operand> operandsStack = InitStackWithoutBracketsBeforeTest();
            List<string> postfix = InitOriginalPostfix();
            List<string> expectedPostfix = new List<string>();
            expectedPostfix.Add("5");
            expectedPostfix.Add("2");
            expectedPostfix.Add("/");
            expectedPostfix.Add("*");
            expectedPostfix.Add("-");
            
            // Act
            FromInfixToPostfixHelper.ReplaceElementsFromStackToString(new Operand("("), operandsStack, postfix);

            // Assert
            CollectionAssert.AreEqual(postfix, expectedPostfix);
        }

        [Test]
        //пока приоритет oператора меньше либо равен приоритету оператора, находящегося на вершине стека выталкиваем верхний элемент стека в выходную строку
        public void ReplaceElementsFromStackToString_WithOperandPriorityMoreThanFirstElementInStack_ShouldReturnOriginalPostfix()
        {
            // Arrange
            Stack<Operand> operandsStack = InitStackWithoutBracketsBeforeTest();
            List<string> postfix = InitOriginalPostfix();
            List<string> expectedPostfix = InitOriginalPostfix();
            
            // Act
            FromInfixToPostfixHelper.ReplaceElementsFromStackToString(new Operand("^"), operandsStack, postfix);

            // Assert
            CollectionAssert.AreEqual(postfix, expectedPostfix);
        }

        [Test]
        //пока приоритет oператора меньше либо равен приоритету оператора, находящегося на вершине стека выталкиваем верхний элемент стека в выходную строку
        public void MoveOperandToStack_WithCorrectedOperand_ShouldMoveOperandToStack()
        {
            // Arrange
            Stack<Operand> operandsStack = InitStackWithoutBracketsBeforeTest();
            Stack<Operand> expectedOperandsStack = InitStackWithoutBracketsBeforeTest();
            Operand operand = new Operand("-");
            expectedOperandsStack.Push(operand);
            
            // Act
            FromInfixToPostfixHelper.MoveOperandToStack(operand, operandsStack);

            // Assert
            operandsStack.Equals(expectedOperandsStack);
            //CollectionAssert.AreEqual(operandsStack, expectedOperandsStack);
        }

        [Test]
        //пока приоритет oператора меньше либо равен приоритету оператора, находящегося на вершине стека выталкиваем верхний элемент стека в выходную строку
        public void MoveOperandToStack_WithClosedBracket_ShouldNotMoveOperandToStack()
        {
            // Arrange
            Stack<Operand> operandsStack = InitStackWithoutBracketsBeforeTest();
            Stack<Operand> expectedOperandsStack = InitStackWithoutBracketsBeforeTest();
            Operand operand = new Operand(")");
            
            // Act
            FromInfixToPostfixHelper.MoveOperandToStack(operand, operandsStack);

            // Assert
            operandsStack.Equals(expectedOperandsStack);
            //CollectionAssert.AreEqual(operandsStack, expectedOperandsStack);
        }

        [Test]
        //Когда входная строка закончилась, выталкиваем все символы из стека в выходную строку
        public void ReplaceAllStackElementsToString_WithThreeOperands_ShouldReplaceAllElementsToString()
        {
            // Arrange
            Stack<Operand> operandsStack = InitStackWithoutBracketsBeforeTest();
            List<string> postfix = InitOriginalPostfix();
            List<string> expectedPostfix = new List<string>();
            expectedPostfix.Add("5");
            expectedPostfix.Add("2");
            expectedPostfix.Add("/");
            expectedPostfix.Add("*");
            expectedPostfix.Add("-");
            
            // Act
            FromInfixToPostfixHelper.ReplaceAllStackElementsToString(operandsStack, postfix);

            // Assert
            CollectionAssert.AreEqual(postfix, expectedPostfix);
        }

        [Test]
        //Когда входная строка закончилась, выталкиваем все символы из стека в выходную строку
        public void ReplaceAllStackElementsToString_WithNoOneOperands_ShouldReplaceNothing()
        {
            // Arrange
            Stack<Operand> operandsStack = new Stack<Operand>();
            List<string> postfix = InitOriginalPostfix();
            List<string> expectedPostfix = new List<string>();
            expectedPostfix.Add("5");
            expectedPostfix.Add("2");
            
            // Act
            FromInfixToPostfixHelper.ReplaceAllStackElementsToString(operandsStack, postfix);

            // Assert
            CollectionAssert.AreEqual(postfix, expectedPostfix);
        }

        [Test]
        //Когда входная строка закончилась, выталкиваем все символы из стека в выходную строку
        public void TranslateToPostfix_WithInfix_ShouldReturnPostfix()
        {
            // Arrange
            string[] expectedPostfix = new string[3];
            expectedPostfix[0] = "5";
            expectedPostfix[1] = "2";
            expectedPostfix[2] = "+";

            // Act
            string[] resultPostfix = FromInfixToPostfixHelper.TranslateToPostfix(new[] { "5", "+", "2" });

            // Assert
            CollectionAssert.AreEqual(resultPostfix, expectedPostfix);
        }

        [Test]
        //Когда входная строка закончилась, выталкиваем все символы из стека в выходную строку
        public void TranslateToPostfix_WithInfixWithBrackets_ShouldReturnPostfix()
        {
            // Arrange
            string[] expectedPostfix = new string[5];
            expectedPostfix[0] = "5";
            expectedPostfix[1] = "2";
            expectedPostfix[2] = "+";
            expectedPostfix[3] = "2";
            expectedPostfix[4] = "*";

            // Act
            string[] resultPostfix = FromInfixToPostfixHelper.TranslateToPostfix(new[] { "(", "5", "+", "2", ")", "*", "2" });

            // Assert
            CollectionAssert.AreEqual(resultPostfix, expectedPostfix);
        }


        [Test]
        //Когда входная строка закончилась, выталкиваем все символы из стека в выходную строку
        public void TranslateToPostfix_WithInfixWithBrackets_ShouldReturnCorrectedPostfix()
        {
            // Arrange
            string[] expectedPostfix = new string[5];
            expectedPostfix[0] = "5";
            expectedPostfix[1] = "2";
            expectedPostfix[2] = "*";
            expectedPostfix[3] = "2";
            expectedPostfix[4] = "*";

            // Act
            string[] resultPostfix = FromInfixToPostfixHelper.TranslateToPostfix(new[] { "(", "5", "+", "2", ")", "*", "2" });

            // Assert
            CollectionAssert.AreNotEqual(resultPostfix, expectedPostfix);
        }
    }
}