using System;
using System.Collections.Generic;

namespace Stack_Postfix
{
    class Program
    {
        static void Main(string[] args)
        {
            //прошлый вариант перевода из инфиксной записи в постфиксную
            //string[] postfix = new Infix().TranslateToPostfix(args);
            //new PostfixCounting().PostfixCount(postfix);

            Stack<Operands> operandsStack = new Stack<Operands>();
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
                    Operands operand = new Operands {Operand = token};
                    if (operandsStack.Count != 0)
                    {
                        //Если символ является закрывающей скобкой:
                        //До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку. 
                        if (operand.Priority == 5)
                        {
                            while (operandsStack.Peek().Priority != 4)
                            {
                                postfix.Add(operandsStack.Pop().Operand);
                            }
                            operandsStack.Pop();
                        }
                        else
                        {
                            //пока приоритет oператора меньше либо равен приоритету оператора, находящегося на вершине стека выталкиваем верхний элемент стека в выходную строку
                            while (operand.Priority >= operandsStack.Peek().Priority)
                            {
                                postfix.Add(operandsStack.Pop().Operand);
                                if (operandsStack.Count == 0)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //помещаем оператор в стек (если это не ")")
                    if (operand.Priority != 5)
                    {
                        operandsStack.Push(operand); 
                    }
                }
            }

            //Когда входная строка закончилась, выталкиваем все символы из стека в выходную строку.
            while (operandsStack.Count != 0)
            {
                postfix.Add(operandsStack.Pop().Operand);
            }

            //вывести на экран выходную строку
            Console.WriteLine(string.Join(" ", postfix));
            new PostfixCounting().PostfixCount(postfix.ToArray());
        }
    }
}
