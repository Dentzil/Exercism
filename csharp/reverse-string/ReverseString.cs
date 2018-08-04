namespace Exercism_reverse_string
{
    using System.Linq;

    public static class ReverseString
    {
        public static string Reverse(string input)
        {
            return string.Concat(input.Reverse());
        }
    }
}
