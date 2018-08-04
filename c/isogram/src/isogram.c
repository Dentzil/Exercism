#include "isogram.h"

bool is_isogram(const char* str)
{
    int char_repetitions[27] = { 0 };
    
    for (; *str != '\0'; str++)
    {
        if (!isalpha(*str))
        {
            continue;
        }
        
        int index;
        if (islower(*str))
        {
            index = *str - 'a';
        }
        else
        {
            index = *str - 'A';
        }
        
        if (++char_repetitions[index] > 1)
        {
            return false;
        }
    }
    
    return true;
}
