#include "meetup.h"

int meetup_day_of_month(int year, int month, const char* day_descriptor, const char* day_of_week_str)
{
    int week_day = get_week_day(day_of_week_str);
    int days_in_month = get_days_in_month(year, month);
    
    if (week_day == -1 || days_in_month == -1)
    {
        return -1;
    }

    int day_in_month = get_first_day_in_month(year, month, week_day);

    if (strcmp("first", day_descriptor) == 0)
    {
        // there's no need to changed the return value
    }
    else if (strcmp("second", day_descriptor) == 0)
    {
        day_in_month += 7;
    }
    else if (strcmp("third", day_descriptor) == 0)
    {
        day_in_month += 14;
    }
    else if (strcmp("fourth", day_descriptor) == 0)
    {
        day_in_month += 21;
    }
    else if (strcmp("fifth", day_descriptor) == 0)
    {
        day_in_month += 28;

        if (day_in_month > days_in_month)
        {
            day_in_month = 0;
        }
    }
    else if (strcmp("teenth", day_descriptor) == 0)
    {
        day_in_month += day_in_month >= 6 ? 7 : 14;
    }
    else if (strcmp("last", day_descriptor) == 0)
    {
        do
        {
            day_in_month += 7;
        } while (day_in_month + 7 <= days_in_month);

        return day_in_month;
    }
    else
    {
        day_in_month = -1;
    }

    return day_in_month;
}

int get_week_day(const char* day_of_week_str)
{
    if (strcmp("Sunday", day_of_week_str) == 0)
    {
        return 0;
    }
    else if (strcmp("Monday", day_of_week_str) == 0)
    {
        return 1;
    }
    else if (strcmp("Tuesday", day_of_week_str) == 0)
    {
        return 2;
    }
    else if (strcmp("Wednesday", day_of_week_str) == 0)
    {
        return 3;
    }
    else if (strcmp("Thursday", day_of_week_str) == 0)
    {
        return 4;
    }
    else if (strcmp("Friday", day_of_week_str) == 0)
    {
        return 5;
    }
    else if (strcmp("Saturday", day_of_week_str) == 0)
    {
        return 6;
    }
    else 
    {
        return -1;
    }
}

int get_days_in_month(int year, int month)
{
    if (month < 1 || month > 12)
    {
        return -1;
    }

    int days_in_month = days_in_monthes[month - 1];

    if (is_february(month) && is_leap_year(year))
    {
        days_in_month++;
    }

    return days_in_month;
}

int get_first_day_in_month(int year, int month, int week_day)
{
    struct tm info;

    info.tm_year = year - 1900;
    info.tm_mon = month - 1;
    info.tm_mday = 1;
    info.tm_hour = 0;
    info.tm_min = 0;
    info.tm_sec = 1;
    info.tm_isdst = -1;

    mktime(&info);

    int first_day_in_month = 1;
    int week_day_delta = info.tm_wday - week_day;

    first_day_in_month += week_day_delta <= 0 ? -week_day_delta : 7 - week_day_delta;
        
    return first_day_in_month;
}

int is_february(int month)
{
    return month == 2;
}

int is_leap_year(int year)
{
    return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
}
