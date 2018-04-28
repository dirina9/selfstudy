namespace Stack_Postfix
{
    public class InfixCountingService
    {
        public static int InfixCounting(string[] args)
        {
            string[] postfix = FromInfixToPostfixHelper.TranslateToPostfix(args);
            return PostfixCounting.PostfixCount(postfix);
        }
    }
}