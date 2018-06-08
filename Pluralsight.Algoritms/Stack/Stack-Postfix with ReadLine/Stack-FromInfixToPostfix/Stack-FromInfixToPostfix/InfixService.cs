using System;
using System.Text.RegularExpressions;

namespace Stack_FromInfixToPostfix
{
    public static class InfixService
    {
        public static MatchCollection ClearInfixString(string str)
        {
            string pattern = @"[\d]+|[-+*/^()]";
            Regex rgx = new Regex(pattern);
            return rgx.Matches(str.Trim());
        }
    }
}