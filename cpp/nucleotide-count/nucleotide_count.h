#ifndef NUCLEOTIDE_COUNT_H
#define NUCLEOTIDE_COUNT_H

#include <map>
#include <stdexcept>
#include <string>

namespace dna
{
    class counter
    {
    private:
        std::map<char, int> _nucleotide_counts;
        
        void check_nucleotide(char) const;
        
    public:
        counter(std::string dna);
        
        int count(char) const;
        std::map<char, int> nucleotide_counts() const;
    };
}

#endif
