using System.Linq;

namespace Exercism_bob
{
    public class Bob
    {
        public static string Hey(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return "Fine. Be that way!";
            }

            if (text.Any(e => char.IsLetter(e)) &&
                text.Where(e => char.IsLetter(e)).All(e => char.IsUpper(e)))
            {
                return "Whoa, chill out!";
            }

            if (text.TrimEnd().Last() == '?')
            {
                return "Sure.";
            }

            return "Whatever.";
        }
    }
}
