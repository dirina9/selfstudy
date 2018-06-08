using System.Text.RegularExpressions;

namespace Stack_FromInfixToPostfix
{
    public static class Calculator
    {
        public static int Calculate(string str)
        {
            MatchCollection infixCollection = InfixService.ClearInfixString(str);
            string[] postfix = FromInfixToPostfixHelper.TranslateToPostfix(infixCollection);
            return PostfixService.PostfixCount(postfix);
        }
    }
}