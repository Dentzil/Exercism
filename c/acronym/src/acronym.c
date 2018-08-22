#include "acronym.h"

char *abbreviate(const char *const phrase)
{
    if (phrase == NULL)
    {
        return NULL;
    }
    
    bool take_it = true;
    char* abbreviate = (char*)calloc(strlen(phrase), sizeof(char));
    char* abbreviate_ptr = abbreviate;
    
    for (size_t i = 0; phrase[i] != '\0'; i++)
    {
        if (isalpha(phrase[i]))
        {
            if (take_it)
            {
                *(abbreviate_ptr++) = toupper(*phrase);
                take_it = false;
            }
        }
        else
        {
            take_it = true;
        }
    }
    
    *abbreviate_ptr = '\0';
    if (strlen(abbreviate) == 0)
    {
        return NULL;
    }
    
    return abbreviate;
}
