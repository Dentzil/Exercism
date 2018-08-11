#ifndef BRACKET_PUSH_H
#define BRACKET_PUSH_H

#include <stdbool.h>
#include <stdlib.h>

bool is_paired(const char *const);
bool is_open_bracket(char);
bool is_close_bracket(char);
char get_opposite_bracket(char);

#endif
