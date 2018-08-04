namespace Exercism_proverb
{
    using System;
    using System.Collections.Generic;

    public class Proverb
    {
        private static List<string> proverbialLines = new List<string>
        {
            "For want of a nail the shoe was lost.",
            "For want of a shoe the horse was lost.",
            "For want of a horse the rider was lost.",
            "For want of a rider the message was lost.",
            "For want of a message the battle was lost.",
            "For want of a battle the kingdom was lost.",
            "And all for the want of a horseshoe nail."
        };

        public static string AllLines()
        {
            return string.Join("\n", proverbialLines);
        }

        public static string Line(int lineNumber)
        {
            if (lineNumber <= 0 || lineNumber > proverbialLines.Count)
            {
                throw new ArgumentOutOfRangeException($"Wrong line number: {lineNumber}");
            }

            return proverbialLines[lineNumber - 1];
        }
    }
}
