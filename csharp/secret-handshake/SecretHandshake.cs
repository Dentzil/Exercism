using static System.Math;

using System;
using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{
    private static List<string> events = new List<string> { "wink", "double blink", "close your eyes", "jump" };

    public static string[] Commands(int command)
    {
        if (command < 0 || command > 31)
        {
            throw new ArgumentOutOfRangeException($"Wrong command: {command}");
        }

        List<string> returnEvents = events.Where((e, i) => (command & (int)Pow(2, i)) == (int)Pow(2, i)).ToList();

        if ((command & 16) == 16)
        {
            returnEvents.Reverse();
        }

        return returnEvents.ToArray();
    }
}
