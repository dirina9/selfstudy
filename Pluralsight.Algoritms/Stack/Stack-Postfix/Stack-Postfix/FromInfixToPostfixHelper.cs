using System;
using System.Collections.Generic;

namespace Stack_Postfix
{
    public class FromInfixToPostfixHelper
    {
        public string[] TranslateToPostfix(string[] args)
        {
            Stack<Operand> operandsStack = new Stack<Operand>();
            List<string> postfix = new List<string>();
            int value;

            foreach (string token in args)
            {
                //if the value is an integer...
                if (int.TryParse(token, out value))
                {
                    postfix.Add(value.ToString());
                }
                else
                {
                    Operand operand = new Operand(token);
                    if (operandsStack.Count != 0)
                    {
                        //Если символ является закрывающей скобкой
                        if (operand.Priority == 5)
                        {
                            //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку
                            HandleBracket(operandsStack, postfix);
                        }
                        else
                        {
                            //пока приоритет oператора меньше либо равен приоритету оператора, находящегося на вершине стека выталкиваем верхний элемент стека в выходную строку
                            ReplaceElementsFromStackToString(operand, operandsStack, postfix);
                        }
                    }
                    //помещаем оператор в стек (если это не ")")
                    MoveOperandToStack(operand, operandsStack);
                }
            }

            //Когда входная строка закончилась, выталкиваем все символы из стека в выходную строку.
            ReplaceAllStackElementsToString(operandsStack, postfix);

            //вывести на экран выходную строку
            Console.WriteLine(string.Join(" ", postfix));
            return postfix.ToArray();
        }

        public void HandleBracket(Stack<Operand> operandsStack, List<string> postfix)
        {
            while (operandsStack.Peek().Priority != 4)
            {
                postfix.Add(operandsStack.Pop().Value);
            }
            operandsStack.Pop();  
        }

        public void ReplaceElementsFromStackToString(Operand operand, Stack<Operand> operandsStack, List<string> postfix)
        {
            while (operand.Priority >= operandsStack.Peek().Priority)
            {
                postfix.Add(operandsStack.Pop().Value);
                if (operandsStack.Count == 0)
                {
                    break;
                }
            }
        }

        public void MoveOperandToStack(Operand operand, Stack<Operand> operandsStack)
        {
            if (operand.Priority != 5)
            {
                operandsStack.Push(operand);
            }
        }

        public void ReplaceAllStackElementsToString(Stack<Operand> operandsStack, List<string> postfix)
        {
            while (operandsStack.Count != 0)
            {
                postfix.Add(operandsStack.Pop().Value);
            }
        }
    }
}