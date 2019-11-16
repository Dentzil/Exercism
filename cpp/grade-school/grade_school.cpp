#include "grade_school.h"

namespace grade_school
{
    void school::add(const std::string& name, int grade)
    {
        if (has_grade(grade))
        {
            _roster.at(grade).push_back(name);
            std::sort(_roster.at(grade).begin(), _roster.at(grade).end());
        }
        else
        {
            _roster.insert(std::pair<int, std::vector<std::string>>(grade, { name }));
        }
    }

    std::vector<std::string> school::grade(int grade) const
    {
        return has_grade(grade) ? _roster.at(grade) : std::vector<std::string>();
    }

    bool school::has_grade(int grade) const
    {
        return _roster.find(grade) != _roster.end();
    }

    std::map<int, std::vector<std::string>> school::roster() const
    {
        return _roster;
    }
}
