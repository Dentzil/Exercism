#include <stdio.h>
#include "pangram.h"

bool is_pangram(const char *sentence)
{
    if (sentence == NULL)
    {
        return false;
    }

    const size_t alphabet_length = 26;
    int repetitions[alphabet_length];

    for (size_t i = 0; i < alphabet_length; i++)
    {
        repetitions[i] = 0;
    }

    for (; *sentence != '\0'; sentence++)
    {
        if (isalpha(*sentence))
        {
            int index = tolower(*sentence) - 'a';
            repetitions[index]++;
        }
    }

    for (size_t i = 0; i < alphabet_length; i++)
    {
        if (repetitions[i] == 0)
        {
            return false;
        }
    }

    return true;
}
