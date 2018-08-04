namespace Exercism_Pangram
{
    using System.Linq;

    public class Pangram
    {
        public static bool IsPangram(string input)
        {
            const string Alphabet = "abcdefghijklmnopqrstuvwxyz";

            string text = input.ToLower();

            return Alphabet.All(e => text.Contains(e));
        }
    }
}
