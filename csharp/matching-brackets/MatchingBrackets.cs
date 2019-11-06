using System.Collections.Generic;

public static class MatchingBrackets
{
    private static Dictionary<char, char> _bracketsMap = new Dictionary<char, char>
    {
        [')'] = '(',
        [']'] = '[',
        ['}'] = '{'
    };

    public static bool IsPaired(string input)
    {
        var stack = new Stack<char>();

        foreach (var c in input)
        {
            if (IsOpenBracket(c))
            {
                stack.Push(c);
            }
            else if (IsCloseBracket(c))
            {
                if (stack.Count == 0 || _bracketsMap[c] != stack.Pop())
                {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }

    private static bool IsOpenBracket(char c) => c == '(' || c == '[' || c == '{';

    private static bool IsCloseBracket(char c) => c == ')' || c == ']' || c == '}';
}
