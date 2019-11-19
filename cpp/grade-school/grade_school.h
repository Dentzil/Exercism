#if !defined(GRADE_SCHOOL_H)
#define GRADE_SCHOOL_H

#include <algorithm>
#include <map>
#include <string>
#include <vector>

namespace grade_school
{
    class school
    {
    private:
        std::vector<std::string> blank_grade;
        std::map<int, std::vector<std::string>> _roster;
        
        bool has_grade(int grade) const;
        
    public:
        void add(const std::string& name, int grade);
        const std::vector<std::string>& grade(int grade) const;
        const std::map<int, std::vector<std::string>>& roster() const;
    };
}

#endif
