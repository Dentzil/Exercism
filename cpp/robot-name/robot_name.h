#if !defined(ROBOT_NAME_H)
#define ROBOT_NAME_H

#include <random>
#include <string>
#include <unordered_set>

namespace robot_name
{
    class robot
    {
    private:
        static std::unordered_set<std::string> _robot_names_set;
        
        std::string _robot_name;
        
        void generate_name();
    public:
        robot();
        
        std::string name() const;
        void reset();
    };
}

#endif
