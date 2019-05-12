#include "acronym.h"

char* get_mutable_copy_of(const char* const text);

char* abbreviate(const char* const phrase)
{
    if (phrase == NULL)
    {
        return NULL;
    }
    
    char* abbreviate = (char*)calloc(strlen(phrase), sizeof(char));
    char* abbreviate_ptr = abbreviate;

    char* mutable_phrase = get_mutable_copy_of(phrase);
    const char* const delimeters = " -";

    char* token = strtok(mutable_phrase, delimeters);
    while(token != NULL)
    {
        *(abbreviate_ptr++) = toupper(token[0]);

        token = strtok(NULL, delimeters);
    }
    
    *abbreviate_ptr = '\0';
    if (abbreviate_ptr == abbreviate)
    {
        return NULL;
    }
    
    return abbreviate;
}

char* get_mutable_copy_of(const char* const text)
{
    char* mutable_text = (char*)calloc(strlen(text) + 1, sizeof(char));
    strcpy(mutable_text, text);
    
    return mutable_text;
}
