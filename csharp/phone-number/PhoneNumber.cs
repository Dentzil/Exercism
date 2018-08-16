using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string number)
    {
        number = Regex.Replace(number, @"[^\d]", "");

        var match = Regex.Match(number, @"^1?(?<ac>[2-9]\d{2})(?<ec>[2-9]\d{2})(?<sn>\d{4})$");
        if (!match.Success)
        {
            throw new ArgumentException();
        }

        return $"{match.Groups["ac"].Value}{match.Groups["ec"].Value}{match.Groups["sn"].Value}";
    }
}
