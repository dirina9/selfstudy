using System;
using System.Collections.Generic;

namespace Stack_Postfix
{
    class Program
    {
        static void Main(string[] args)
        {
            //new PostfixCounting().PostfixCount(args);
            string[] postfix = new Infix().TranslateToPostfix(args);
            new PostfixCounting().PostfixCount(postfix);
        }
    }
}
