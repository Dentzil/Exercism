#include "grade_school.h"

namespace grade_school
{
    void school::add(const std::string& name, int grade)
    {
        if (has_grade(grade))
        {
            std::vector<std::string>& students = _roster.at(grade);
            students.insert(std::upper_bound(students.begin(), students.end(), name), name);
        }
        else
        {
            _roster.insert(std::pair<int, std::vector<std::string>>(grade, { name }));
        }
    }

    const std::vector<std::string>& school::grade(int grade) const
    {
        return has_grade(grade) ? _roster.at(grade) : blank_grade;
    }

    bool school::has_grade(int grade) const
    {
        return _roster.find(grade) != _roster.end();
    }

    const std::map<int, std::vector<std::string>>& school::roster() const
    {
        return _roster;
    }
}
