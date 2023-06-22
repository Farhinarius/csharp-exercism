using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        char[] separators = { ' ', '_', '-' };
        word = String.Join("", word.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries));
        var uniqWord = String.Join("", word.Distinct());

        return word == uniqWord;
    }

    public static bool IsIsogramCycles(string word)
    {
        char[] separators = { ' ', '_', '-' };
        word = String.Join("", word.Split(separators, StringSplitOptions.RemoveEmptyEntries)).ToLower();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
                if (word[i] == word[j])
                    return false;
        }

        return true;
    }
}
