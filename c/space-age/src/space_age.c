#include "space_age.h"

float convert_planet_age(int planet, age_in_sec_t age_in_sec)
{
    switch (planet)
    {
        case MERCURY: return age_in_sec / MERCURY_YEAR_IN_SEC;
        case VENUS: return age_in_sec / VENUS_YEAR_IN_SEC; 
        case EARTH: return age_in_sec / EARTH_YEAR_IN_SEC;
        case MARS: return age_in_sec / MARS_YEAR_IN_SEC;
        case JUPITER: return age_in_sec / JUPITER_YEAR_IN_SEC;
        case SATURN: return age_in_sec / SATURN_YEAR_IN_SEC;
        case URANUS: return age_in_sec / URANUS_YEAR_IN_SEC;
        case NEPTUNE: return age_in_sec / NEPTUNE_YEAR_IN_SEC;
    }

    return -1;
}
