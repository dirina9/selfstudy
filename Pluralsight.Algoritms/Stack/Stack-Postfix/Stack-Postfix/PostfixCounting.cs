using System;
using System.Collections.Generic;

namespace Stack_Postfix
{
    public static class PostfixCounting
    {
        public static int PostfixCount(string[] args)
        {
            //The stack of integers not yet operated on
            Stack<int> values = new Stack<int>();

            foreach (string token in args)
            {
                //if the value is an integer...
                int value;
                if (int.TryParse(token, out value))
                {
                    //...push it to the stack
                    values.Push(value);
                }
                else
                {
                    //otherwise evaluate the expression... (right and left hands side)
                    int rhs = values.Pop();
                    int lhs = values.Pop();

                    //...and pop the result back to the stack
                    switch (token)
                    {
                        case "^":
                            values.Push(lhs ^ rhs);
                            break;
                        case "+":
                            values.Push(lhs + rhs);
                            break;
                        case "-":
                            values.Push(lhs - rhs);
                            break;
                        case "*":
                            values.Push(lhs * rhs);
                            break;
                        case "/":
                            values.Push(lhs / rhs);
                            break;
                        default:
                            throw new ArgumentException(string.Format("Unrecognized token: {0}", token));
                    }
                }
            }
            int result = values.Peek();
            //the last item on the stack is the result
            Console.WriteLine(result);
            return result;
        }
    }
}