using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class Solution
{
    private static char[] Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

    public static bool IsPangramMy(string input)
    {
        if (input == "")
        {
            return false;
            throw new Exception("EmptyStringException");
        }

        int count = 0;

        foreach (var alphCh in Alphabet)
        {
            foreach (var ch in input.ToLower())
            {
                if (ch == alphCh)
                {
                    count++;
                    break;
                }
            }
        }

        if (count == 26) return true;
        else return false;
    }

    public static bool IsPangramOne(string input)
    => input.ToLower().Where(ch => char.IsLetter(ch)).ToArray().Distinct().Count() == 26;

    public static bool IsPangramTwo(string input) 
    => "abcdefghijklmnopqrstuvwxyz".All(input.ToLower().Contains);

    public static bool IsPangramThree(string input)
    {
        var lowerInput = input.ToLower();

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (!lowerInput.Contains(c))
                return false;
        }

        return true;
    }

    public static bool IsPangram(string input) 
    => "abcdefghijklmnopqrstuvwxyz".All(alphCh => input.ToLower().Contains(alphCh));
}
