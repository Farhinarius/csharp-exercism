using System.Collections.Generic;
using System.Security.Cryptography;
using System;

public class Robot
{
    private static int seed;

    private Random rand = new Random(seed++);

    public string Name { get; private set; }

    public Robot() => AssignNewUniqueName();

    public void Reset() => AssignNewUniqueName();

    private void AssignNewUniqueName()
    {
        Name = "";
        for (int i = 0; i < 2; i++) Name += (char)rand.Next('A', 'Z');
        Name += rand.Next(100, 1000).ToString();
    }
}