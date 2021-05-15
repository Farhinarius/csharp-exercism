using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    private const string nucleotideAlpha = "ACGT";

    public static IDictionary<char, int> Count(string sequence) => sequence.Any(ch => !nucleotideAlpha.Contains(ch)) ?
            throw new ArgumentException("Invalid character in sequence") :
            nucleotideAlpha.ToDictionary(alCh => alCh, alCh => sequence.Count(ch => ch == alCh));
}