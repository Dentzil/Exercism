using System.Collections.Generic;
using System.Linq;

public class Proverb
{
    public static string[] Recite(string[] proverbs)
    {
        if (proverbs.Length == 0)
        {
            return new string[0];
        }

        var result = new List<string>();
        for (int i = 0; i < proverbs.Length - 1; i++)
        {
            var pair = proverbs.Skip(i).Take(2).ToArray();
            result.Add($"For want of a {pair[0]} the {pair[1]} was lost.");
        }

        result.Add($"And all for the want of a {proverbs[0]}.");

        return result.ToArray();
    }
}
