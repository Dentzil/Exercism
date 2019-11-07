#include "word_count.h"

char* copy(const char* const);
void delete_illegal_chars(char *);
bool is_apostroph(char);
int find_word(word_count_word_t *, const char *);

int word_count(const char* const input_text, word_count_word_t* words)
{
    memset(words, 0, sizeof(word_count_word_t) * MAX_WORDS);
    
    int count = 0;
    
    char* text = copy(input_text);
    const char* const delimeters = " .,\n";
    
    char* word = strtok(text, delimeters);
    while(word != NULL)
    {
        delete_illegal_chars(word);
        if (strlen(word) > MAX_WORD_LENGTH)
        {
            free(text);
            return EXCESSIVE_LENGTH_WORD;
        }

        int index = find_word(words, word);
        if (index != -1)
        {
            words[index].count++;
        }
        else
        {
            if (++count > MAX_WORDS)
            {
                free(text);
                return EXCESSIVE_NUMBER_OF_WORDS;
            }
            
            words[count - 1].count = 1;
            strcpy(words[count - 1].text, word);
        }
        
        word = strtok(NULL, delimeters);
    }
    
    free(text);
    
    return count;
}

char* copy(const char* const text)
{
    char* copy_text = (char*)calloc(strlen(text) + 1, sizeof(char));
    strcpy(copy_text, text);
    
    return copy_text;
}

void delete_illegal_chars(char* word)
{
    size_t i = 0;
    
    for (char* ptr = word; *ptr != '\0'; ptr++)
    {
        if (isalnum(*ptr))
        {
            *(word + i++) = tolower(*ptr);
        }
        else if (is_apostroph(*ptr))
        {
            if (i != 0 && *(ptr + 1) != '\0')
            {
                *(word + i++) = *ptr;
            }
        }
    }
    
    *(word + i) = '\0';
}

bool is_apostroph(char c)
{
    return c == '\'';
}

int find_word(word_count_word_t* words, const char* word)
{
    for (size_t i = 0; i < MAX_WORDS; i++)
    {
        if (strcmp(words[i].text, word) == 0)
        {
            return i;
        }
    }
    
    return -1;
}
