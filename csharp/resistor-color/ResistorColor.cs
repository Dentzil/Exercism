using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    private static List<string> _colors = new List<string> { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color)
    {
        if (color is null)
        {
            throw new ArgumentNullException(nameof(color));
        }

        int number = _colors.FindIndex(e => e == color);
        if (number == -1)
        {
            throw new ArgumentException($"Unknown color: {color}");
        }

        return number;
    }

    public static string[] Colors()
    {
        return _colors.ToArray();
    }
}
