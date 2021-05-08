using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class AcronymByRegex
{
    public static string Abbreviate(string phrase)
    {
        MatchCollection mc = Regex.Matches(phrase, @"\b[a-zA-Z]");
        phrase = "";
        foreach (var match in mc)
        {
            phrase += match;
        }
        return phrase.ToUpper();
    }
}