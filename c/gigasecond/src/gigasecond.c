#include "gigasecond.h"

time_t gigasecond_after(time_t start_date)
{
    start_date += GIGASECOND;

    return start_date;
}
