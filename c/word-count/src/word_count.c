#include "word_count.h"

void initialize_return_words(word_count_word_t *);
char* get_writable_copy_of(const char *);
void clear_word(char *);
bool isapostroph(char);
int find_word(word_count_word_t *, const char *);

int word_count(const char *input_text, word_count_word_t *words)
{
    initialize_return_words(words);
    
    int count = 0;
    
    char *text = get_writable_copy_of(input_text);
    const char *delimeters = " .,\n";
    
    char *word = strtok(text, delimeters);
    while(word != NULL)
    {
        clear_word(word);
        if (strlen(word) > MAX_WORD_LENGTH)
        {
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

void initialize_return_words(word_count_word_t *words)
{
    memset(words, 0, sizeof(word_count_word_t) * MAX_WORDS);
}

char* get_writable_copy_of(const char *text)
{
    char *writable_text = (char*)calloc(strlen(text) + 1, sizeof(char));
    strcpy(writable_text, text);
    
    return writable_text;
}

void clear_word(char *word)
{
    size_t i = 0;
    
    for (char *ptr = word; *ptr != '\0'; ptr++)
    {
        if (isalnum(*ptr))
        {
            *(word + i++) = tolower(*ptr);
        }
        else if (isapostroph(*ptr))
        {
            if (i != 0 && *(ptr + 1) != '\0')
            {
                *(word + i++) = *ptr;
            }
        }
    }
    
    *(word + i) = '\0';
}

bool isapostroph(char c)
{
    return c == '\'';
}

int find_word(word_count_word_t *words, const char *word)
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
