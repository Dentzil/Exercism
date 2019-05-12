#pragma once

#include <ctype.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>

#define MAX_WORDS 20
#define MAX_WORD_LENGTH 50
#define EXCESSIVE_LENGTH_WORD -1
#define EXCESSIVE_NUMBER_OF_WORDS -2

typedef struct word_count_word {
    char text[MAX_WORD_LENGTH + 1];
    int count;
} word_count_word_t;

// word_count - routine to classify the unique words and their frequency in a test input string
// inputs:
//    input_text =  a null-terminated string containing that is analyzed
//
// outputs:
//    words = allocated structure to record the words found and their frequency
//    uniqueWords - number of words in the words structure
//           returns a negative number if an error.
//           words will contain the results up to that point.
int word_count(const char* const input_text, word_count_word_t * words);
