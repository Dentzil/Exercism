#include "isogram.h"

bool is_isogram(const char *const str)
{
    int char_repetitions[26] = { 0 };
    
    for (size_t i = 0; str[i] != '\0'; i++)
    {
        if (!isalpha(str[i]))
        {
            continue;
        }
        
        int index;
        if (islower(str[i]))
        {
            index = str[i] - 'a';
        }
        else
        {
            index = str[i] - 'A';
        }
        
        if (++char_repetitions[index] > 1)
        {
            return false;
        }
    }
    
    return true;
}
