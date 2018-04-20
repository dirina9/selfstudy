using System;

namespace Stack_Postfix
{
    class Operands
    {
        private string operand;
        private int priority;

        public int Priority
        {
            get { return IdentifyPriority(operand); }
        }

        public string Operand
        {
            get { return operand; }
            set { operand = value; }
        }

        private int IdentifyPriority(string op){
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
                    throw new ArgumentException(string.Format("Unrecognized operand: {0}", operand));
            }
        }
    }
}