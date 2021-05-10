using System;
using System.Linq;
public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand) => (firstStrand.Length != secondStrand.Length) ?
        throw new ArgumentException("Input strings must be equal") :
        firstStrand.Zip(secondStrand).Count(charTuple => charTuple.First != charTuple.Second);
}