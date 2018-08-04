#ifndef MEETUP_H
#define MEETUP_H

#include <stdlib.h>
#include <string.h>
#include <time.h>

static int days_in_monthes[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

int meetup_day_of_month(int, int, const char*, const char*);
int get_week_day(const char*);
int get_first_day_in_month(int, int, int);
int get_days_in_month(int, int);
int is_february(int);
int is_leap_year(int);

#endif
