using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    private static Dictionary<string, int> _colorNumberMap = new Dictionary<string, int>
    {
        ["black"] = 0,
        ["brown"] = 1,
        ["red"] = 2,
        ["orange"] = 3,
        ["yellow"] = 4,
        ["green"] = 5,
        ["blue"] = 6,
        ["violet"] = 7,
        ["grey"] = 8,
        ["white"] = 9
    };

    public static int ColorCode(string color)
    {
        if (color is null)
        {
            throw new ArgumentNullException(nameof(color));
        }

        if (_colorNumberMap.TryGetValue(color, out int number) == false)
        {
            throw new ArgumentException($"Unknown color: {color}");
        }

        return number;
    }

    public static string[] Colors()
    {
        return _colorNumberMap.Keys.ToArray();
    }
}
