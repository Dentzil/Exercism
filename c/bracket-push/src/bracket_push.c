#include "bracket_push.h"

bool is_paired(const char *const input)
{
    size_t stack_count = 0;
    size_t stack_size = 10;
    char *stack = (char *)malloc(stack_size);
    
    for (size_t i = 0; input[i] != '\0'; i++)
    {
        if (is_open_bracket(input[i]))
        {
            if (stack_count == stack_size)
            {
                size_t new_stack_size = stack_size * 2;
                stack = (char*)realloc(stack, new_stack_size < stack_size ? SIZE_MAX : new_stack_size);
            }

            stack[stack_count++] = input[i];
        }
        else if (is_close_bracket(input[i]))
        {
            if (stack_count == 0 || get_opposite_bracket(input[i]) != stack[--stack_count])
            {
                return false;
            }
        }
    }

    if (stack_count != 0)
    {
        return false;
    }

    return true;
}

bool is_open_bracket(char c)
{
    return c == '[' || c == '{'  || c == '(';
}

bool is_close_bracket(char c)
{
    return c == ']' || c == '}' || c == ')';
}

char get_opposite_bracket(char c)
{
    if (c == '{') return '}';
    if (c == '}') return '{';
    if (c == '[') return ']';
    if (c == ']') return '[';
    if (c == '(') return ')';
    if (c == ')') return '(';

    return c;
}
