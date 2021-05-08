using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] separators = { ' ', '_', '-' };
        return String.Join( "", phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => x[0]) ).ToUpper();
    }
}