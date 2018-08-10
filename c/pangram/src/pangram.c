#include <stdio.h>
#include "pangram.h"

bool is_pangram(const char *const sentence)
{
    if (sentence == NULL)
    {
        return false;
    }

    int repetitions[26] = { 0 };

    for (size_t i = 0; sentence[i] != '\0'; i++)
    {
        if (isalpha(sentence[i]))
        {
            repetitions[tolower(sentence[i]) - 'a']++;
        }
    }

    for (size_t i = 0; i < 26; i++)
    {
        if (repetitions[i] == 0)
        {
            return false;
        }
    }

    return true;
}
