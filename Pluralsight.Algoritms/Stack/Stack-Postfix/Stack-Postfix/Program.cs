namespace Stack_Postfix
{
    class Program
    {
        static void Main(string[] args)
        {
            //прошлый вариант перевода из инфиксной записи в постфиксную
            //string[] postfix = new InfixNotUsed().TranslateToPostfix(args);
            //new PostfixCounting().PostfixCount(postfix);

            //новый вариант перевода из инфиксной записи в постфиксную
            InfixCountingService.InfixCounting(args);
        }


    }
}
