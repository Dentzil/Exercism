#include "robot_name.h"

namespace robot_name
{
    std::unordered_set<std::string> robot::_robot_names_set = {};

    robot::robot()
    {
        generate_name();
    }

    void robot::generate_name()
    {
        std::default_random_engine generator;
        std::uniform_int_distribution<int> letters_distribution(65, 90);
        std::uniform_int_distribution<int> digits_distribution(100, 999);
        
        std::string new_robot_name;

        do
        {
            new_robot_name = char(letters_distribution(generator));
            new_robot_name += char(letters_distribution(generator));
            new_robot_name += std::to_string(digits_distribution(generator));
        }
        while (robot::_robot_names_set.insert(new_robot_name).second == false);
        
        _robot_name = new_robot_name;
    }

    std::string robot::name() const
    {
        return _robot_name;
    }

    void robot::reset()
    {
        generate_name();
    }
}
