#include "acronym.h"

char *abbreviate(const char *phrase)
{
    if (phrase == NULL)
    {
        return NULL;
    }
    
    bool take_it = true;
    char* abbreviate = (char*)calloc(strlen(phrase), sizeof(char));
    char* abbreviate_ptr = abbreviate;
    
    for (; *phrase != '\0'; phrase++)
    {
        if (isalpha(*phrase))
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
