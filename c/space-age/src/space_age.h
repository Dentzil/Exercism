#ifndef SPACE_AGE_H
#define SPACE_AGE_H

#include <stdio.h>

#define MERCURY 1
#define VENUS   2
#define EARTH   3
#define MARS    4
#define JUPITER 5
#define SATURN  6
#define URANUS  7
#define NEPTUNE 8

#define EARTH_YEAR_IN_SEC     31557600
#define MERCURY_YEAR_IN_SEC   EARTH_YEAR_IN_SEC / 0.2408467
#define VENUS_YEAR_IN_SEC     EARTH_YEAR_IN_SEC / 0.61519726
#define MARS_YEAR_IN_SEC      EARTH_YEAR_IN_SEC / 1.8808158
#define JUPITER_YEAR_IN_SEC   EARTH_YEAR_IN_SEC / 11.862615
#define SATURN_YEAR_IN_SEC    EARTH_YEAR_IN_SEC / 29.447498
#define URANUS_YEAR_IN_SEC    EARTH_YEAR_IN_SEC / 84.016846
#define NEPTUNE_YEAR_IN_SEC   EARTH_YEAR_IN_SEC / 164.79132

typedef unsigned long long age_in_sec_t;

float convert_planet_age(int planet, age_in_sec_t age_in_sec);

#endif
