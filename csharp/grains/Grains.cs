using System;

public static class Grains
{
    public static ulong Square(int n) => 
    n <= 0 || n > 64 ? throw new ArgumentOutOfRangeException() : n == 1 ? 1 : 2 * Square(n - 1);

    public static ulong Total() => ulong.MaxValue;
}