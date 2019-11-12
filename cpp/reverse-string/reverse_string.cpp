#include "reverse_string.h"

namespace reverse_string
{
    std::string reverse_string(std::string str)
    {
        std::string reversed;
        
        reversed.assign(str.rbegin(), str.rend());
        
        return reversed;
    }
}
