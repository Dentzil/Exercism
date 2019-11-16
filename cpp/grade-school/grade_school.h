#if !defined(GRADE_SCHOOL_H)
#define GRADE_SCHOOL_H

#include <map>
#include <string>
#include <vector>

namespace grade_school
{
    class school
    {
    private:
        std::map<int, std::vector<std::string>> _roster;
        
        bool has_grade(int grade) const;
        
    public:
        school() { }
        
        void add(const std::string& name, int grade);
        std::vector<std::string> grade(int grade) const;
        std::map<int, std::vector<std::string>> roster() const;
    };
}

#endif
