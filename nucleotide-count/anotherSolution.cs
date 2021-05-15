using System;
using System.Collections.Generic;
using System.Linq;

public static class anotherSolution
{
    public static IDictionary<char, int> CountRepeat(string sequence)
    {
        var repetitions = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (var ch in sequence)
        {
            if (!repetitions.ContainsKey(ch))
            {
                throw new ArgumentException("Wrong character in sequence");
            }

            repetitions[ch]++;
        }

        return repetitions;
    }
}