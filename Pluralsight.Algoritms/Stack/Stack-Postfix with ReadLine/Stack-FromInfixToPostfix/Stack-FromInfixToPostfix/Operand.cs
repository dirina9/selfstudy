using System;

namespace Stack_FromInfixToPostfix
{
    public class Operand
    {
        private readonly string value;
        private readonly int priority;

        public int Priority
        {
            get { return priority; }
        }

        public string Value
        {
            get { return value; }
        }

        public Operand(string val)
        {
            value = val;
            priority = IdentifyPriority(value);
        }

        private int IdentifyPriority(string op)
        {
            switch (op)
            {
                case "^":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "+":
                case "-":
                    return 3;
                case "(":
                    return 4;
                case ")":
                    return 5;
                default:
                    throw new ArgumentException(string.Format("Unrecognized operand: {0}", op));
            }
        }
    }
}