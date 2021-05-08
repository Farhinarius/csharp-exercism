using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    static string[] ColorCodes = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color) => Array.IndexOf(ColorCodes, color);

    public static string[] Colors() => ColorCodes;
}