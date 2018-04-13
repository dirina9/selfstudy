using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_Postfix
{
    public class Infix
    {
        public string[] TranslateToPostfix(string[] args)
        {
            //The stack of integers
            Stack<string> operands = new Stack<string>();
            List<string> postfix = new List<string>();

            foreach (string token in args)
            {
                //if the value is an integer...
                int value;
                if (int.TryParse(token, out value))
                {
                    postfix.Add(value.ToString());
                }
                else
                {
                    //if it is an operand...
                    switch (token)
                    {
                        //...push it to the stack
                        case "+":
                            
                            IfFirstOrSecondPriorityOperandIsInStack(operands, postfix);
                            operands.Push(value.ToString("+"));
                            break;
                        case "-":
                            IfFirstOrSecondPriorityOperandIsInStack(operands, postfix);
                            operands.Push(value.ToString("-"));
                            break;
                        //средний приоритет
                        case "*":
                            IfFirstPriorityOperandIsInStack(operands, postfix);
                            operands.Push(value.ToString("*"));
                            break;
                        //средний приоритет
                        case "/":
                            IfFirstPriorityOperandIsInStack(operands, postfix);
                            operands.Push(value.ToString("/"));
                            break;
                        case "(":
                            operands.Push(value.ToString("("));
                            break;
                        //высокий приоритет
                        case "^":
                            operands.Push(value.ToString("^"));
                            break;
                        case ")":
                            while (operands.Peek() != "(")
                            {
                                postfix.Add(operands.Pop()); 
                            }
                            //...remove "(" from the stack
                            operands.Pop();
                            break;
                        default:
                            throw new ArgumentException(string.Format("Unrecognized token: {0}", token));
                    }
                }
            }
            while (operands.Count != 0)
            {
                postfix.Add(operands.Pop());
            }

            Console.WriteLine(string.Join(" ", postfix));
            string[] postfix2 = postfix.ToArray();
            return postfix2;
        }

            //Если первым в стеке является оператор ^ (1 приоритет)
            public void IfFirstPriorityOperandIsInStack(Stack<string> operands, List<string> postfix)
            {
                if (operands.Count != 0)
                {
                    while (operands.Peek() == "^")
                    {
                        postfix.Add(operands.Pop());
                    }  
                }
            }
            
            //Если первым в стеке является оператор *, / (1,2 приоритет)
            public void IfFirstOrSecondPriorityOperandIsInStack(Stack<string> operands, List<string> postfix)
            {
                if (operands.Count != 0)
                {
                    string peekedOperand = operands.Peek();
                    while (peekedOperand == "^" || peekedOperand == "*" || peekedOperand == "/")
                    {
                        postfix.Add(operands.Pop());
                        if (operands.Count != 0)
                        {
                            peekedOperand = operands.Peek();
                        }
                        else
                        {
                            break;
                        }

                    } 
                }

            }
    }
}