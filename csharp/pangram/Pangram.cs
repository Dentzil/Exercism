using System.Collections.Generic;

public class Pangram
{
    private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static bool IsPangram(string input)
    {
        return new HashSet<char>(input.ToLower()).IsSupersetOf(Alphabet);
    }
}
